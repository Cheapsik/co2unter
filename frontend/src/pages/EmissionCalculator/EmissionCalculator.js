import { useState, useEffect } from 'react';
import EmissionList from '../../components/EmissionList/EmissionList';
import { format } from 'date-fns';
import './EmissionCalculator.scss';

const EmissionCalculator = () => {
  const [taskList, setTaskList] = useState(() => {
    const storedTasks = JSON.parse(localStorage.getItem('tasks')) || [];
    return storedTasks || [];
  });

  const [activityType, setActivityType] = useState('privateTransport');
  const [taskName, setTaskName] = useState('');
  const [transportType, setTransportType] = useState('car');
  const [distance, setDistance] = useState(0);
  const [dietType, setDietType] = useState('meat');
  const [waterUsage, setWaterUsage] = useState(0);
  const [waste, setWaste] = useState(0);
  const [internetUsage, setInternetUsage] = useState(0);

  useEffect(() => {
    localStorage.setItem('tasks', JSON.stringify(taskList));
  }, [taskList]);

  const handleSubmit = (e) => {
    e.preventDefault();
    const emissions = calculateEmissions();
    if (taskName) {
      addTask(emissions);
    }
    resetForm();
  };

  const calculateEmissions = () => {
    let totalEmissions = 0;

    switch (activityType) {
      case 'privateTransport':
        totalEmissions = calculateTransportEmissions();
        break;
      case 'diet':
        totalEmissions = calculateDietEmissions();
        break;
      case 'waterConsumption':
        totalEmissions = (waterUsage * 0.02 + waste * 0.5).toFixed(2);
        break;
      case 'internetConsumption':
        totalEmissions = (internetUsage * 0.1).toFixed(2);
        break;
      default:
        break;
    }

    return {
      totalEmissions,
    };
  };

  const calculateTransportEmissions = () => {
    let transportEmissions = 0;
    if (transportType === 'car') {
      transportEmissions = (distance * 0.2).toFixed(2);
    } else if (transportType === 'public transport') {
      transportEmissions = (distance * 0.05).toFixed(2);
    } else {
      transportEmissions = 0;
    }
    return transportEmissions;
  };

  const calculateDietEmissions = () => {
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

    return (parseFloat(dietEmissions) + parseFloat(waterEmissions) + parseFloat(wasteEmissions)).toFixed(2);
  };

  const addTask = (emissions) => {
    const newTask = {
      id: Date.now(),
      name: taskName,
      creationDate: format(new Date(), 'dd/MM/yyyy HH:mm'),
      activityType,
      emissions,
      detailsVisible: false,
    };
    setTaskList((prev) => [...prev, newTask]);
  };

  const resetForm = () => {
    setTaskName('');
    setActivityType('privateTransport');
    setTransportType('car');
    setDistance(0);
    setDietType('meat');
    setWaterUsage(0);
    setWaste(0);
    setInternetUsage(0);
  };

  return (
    <div className="calculator-container">
      <h1>Kalkulator emisji CO₂</h1>
      <form onSubmit={handleSubmit} className="calculator-form">
        <div className="form-group">
          <label>Nazwa:</label>
          <input type="text" value={taskName} onChange={(e) => setTaskName(e.target.value)} />
        </div>

        <div className="form-group">
          <label>Typ aktywności:</label>
          <select value={activityType} onChange={(e) => setActivityType(e.target.value)}>
            <option value="privateTransport">Transport prywatny</option>
            <option value="diet">Konsumpcjonizm</option>
            <option value="waterConsumption">Zużycie wody</option>
            <option value="internetConsumption">Korzystanie z internetu</option>
          </select>
        </div>

        {activityType === 'privateTransport' && (
          <>
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
          </>
        )}

        {activityType === 'diet' && (
          <>
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
          </>
        )}

        {activityType === 'waterConsumption' && (
          <div className="form-group">
            <label>Zużycie wody (litry):</label>
            <input type="number" value={waterUsage} onChange={(e) => setWaterUsage(e.target.value)} />
          </div>
        )}

        {activityType === 'internetConsumption' && (
          <div className="form-group">
            <label>Korzystanie z Internetu (w godzinach):</label>
            <input type="number" value={internetUsage} onChange={(e) => setInternetUsage(e.target.value)} />
          </div>
        )}

        <button type="submit" className="submit-button">Dodaj do listy</button>
      </form>
      {taskList.length && <div className="emission-list-container">
        <h2>Wpisy:</h2>
        <EmissionList taskList={taskList} />
      </div>}
    </div>
  );
};

export default EmissionCalculator;