import { useState, useEffect } from 'react';
import './EmissionCalculator.scss';
import EmissionList from '../../components/EmissionList/EmissionList';

const EmissionCalculator = () => {
  const [taskList, setTaskList] = useState(() => {
        const storedTasks = JSON.parse(localStorage.getItem('tasks')) || [];
        return storedTasks || [];
    });

  const [distance, setDistance] = useState(0);
  const [transportType, setTransportType] = useState('car');
  const [dietType, setDietType] = useState('meat');
  const [waterUsage, setWaterUsage] = useState(0);
  const [waste, setWaste] = useState(0);
  const [taskName, setTaskName] = useState('');


  useEffect(() => {
    localStorage.setItem('tasks', JSON.stringify(taskList));
  }, [taskList]);

  const handleSubmit = (e) => {
    e.preventDefault();
    const emissions = calculateEmissions();
    taskName && addTask(emissions);
    resetForm();
  };

  const calculateEmissions = () => {
    let transportEmissions = 0;
    if (transportType === 'car') {
      transportEmissions = (distance * 0.2).toFixed(2);
    } else if (transportType === 'public transport') {
      transportEmissions = (distance * 0.05).toFixed(2);
    } else if (transportType === 'bike') {
      transportEmissions = 0;
    } else if (transportType === 'walking') {
      transportEmissions = 0;
    }

    let dietEmissions = 0;
    if (dietType === 'meat') {
      dietEmissions = 2.5;
    } else if (dietType === 'vegetarian') {
      dietEmissions = 1.5;
    } else if (dietType === 'vegan') {
      dietEmissions = 1;
    } else if (dietType === 'mediterranean') {
      dietEmissions = 1.2;
    }

    const waterEmissions = (waterUsage * 0.02).toFixed(2);
    const wasteEmissions = (waste * 0.5).toFixed(2); 

    return {
      transportEmissions,
      dietEmissions,
      waterEmissions,
      wasteEmissions,
      totalEmissions: (parseFloat(transportEmissions) + parseFloat(dietEmissions) + parseFloat(waterEmissions) + parseFloat(wasteEmissions)).toFixed(2),
    };
  };

  const addTask = (emissions) => {
    const newTask = {
      id: Date.now(),
      name: taskName,
      transportType,
      distance,
      dietType,
      waterUsage,
      waste,
      emissions,
      detailsVisible: false,
    };
    setTaskList((prev) => [...prev, newTask]);
  };

  const resetForm = () => {
    setDistance(0);
    setTransportType('car');
    setDietType('meat');
    setWaterUsage(0);
    setWaste(0);
    setTaskName('');
  };

  return (
    <div className="calculator-container">
        <h1>Kalkulator emisji CO₂</h1>
      <form onSubmit={handleSubmit} className="calculator-form">
        <div className="form-group">
            <label>Nazwa wpisu:</label>
            <input type="text" value={taskName} onChange={(e) => setTaskName(e.target.value)} />
        </div>
        <div className="form-group">
          <label>Rodzaj transportu:</label>
          <select value={transportType} onChange={(e) => setTransportType(e.target.value)}>
            <option value="car">Samochód</option>
            <option value="public transport">Transport publiczny</option>
            <option value="bike">Rower</option>
            <option value="walking">Pieszo</option>
          </select>
        </div>
        <div className="form-group">
          <label>Przejechane km:</label>
          <input type="number" value={distance} onChange={(e) => setDistance(e.target.value)} />
        </div>
        <div className="form-group">
          <label>Rodzaj diety:</label>
          <select value={dietType} onChange={(e) => setDietType(e.target.value)}>
            <option value="meat">Mięsna</option>
            <option value="vegetarian">Wegetariańska</option>
            <option value="vegan">Wegańska</option>
            <option value="mediterranean">Śródziemnomorska</option>
          </select>
        </div>
        <div className="form-group">
          <label>Zużycie wody (litry):</label>
          <input type="number" value={waterUsage} onChange={(e) => setWaterUsage(e.target.value)} />
        </div>
        <div className="form-group">
          <label>Odpady (kg):</label>
          <input type="number" value={waste} onChange={(e) => setWaste(e.target.value)} />
        </div>
        <button type="submit" className="submit-button">Dodaj do listy</button>
      </form>
      <div className="emission-list-container">
        <h2>Wpisy:</h2>
        <EmissionList taskList={taskList} />
      </div>
    </div>
  );
};

export default EmissionCalculator;