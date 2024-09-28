import { useState } from 'react';
import './EmissionCalculator.scss';

const EmissionCalculator = () => {
  const [distance, setDistance] = useState(0);
  const [transportType, setTransportType] = useState('car');
  const [dietType, setDietType] = useState('meat');
  const [waterUsage, setWaterUsage] = useState(0);
  const [waste, setWaste] = useState(0);
  const [taskList, setTaskList] = useState([]);
  const [taskName, setTaskName] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault();
    const emissions = calculateEmissions();
    taskName && addTask(emissions);
    resetForm();
  };

  const calculateEmissions = () => {
    let transportEmissions = 0;
    if (transportType === 'car') {
      transportEmissions = (distance * 0.2).toFixed(2); // 0.2 kg CO2/km
    } else if (transportType === 'public transport') {
      transportEmissions = (distance * 0.05).toFixed(2); // 0.05 kg CO2/km
    } else if (transportType === 'bike') {
      transportEmissions = 0; // 0 kg CO2
    } else if (transportType === 'walking') {
      transportEmissions = 0; // 0 kg CO2
    }

    let dietEmissions = 0;
    if (dietType === 'meat') {
      dietEmissions = 2.5; // kg CO2/meal
    } else if (dietType === 'vegetarian') {
      dietEmissions = 1.5; // kg CO2/meal
    } else if (dietType === 'vegan') {
      dietEmissions = 1; // kg CO2/meal
    } else if (dietType === 'mediterranean') {
      dietEmissions = 1.2; // kg CO2/meal
    }

    const waterEmissions = (waterUsage * 0.02).toFixed(2); // 0.02 kg CO2/liter
    const wasteEmissions = (waste * 0.5).toFixed(2); // 0.5 kg CO2/kg waste

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

  const removeTask = (id) => {
    setTaskList((prev) => prev.filter((task) => task.id !== id));
  };

  const toggleDetails = (id) => {
    setTaskList((prev) =>
      prev.map((task) =>
        task.id === id ? { ...task, detailsVisible: !task.detailsVisible } : task
      )
    );
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
      <h1>Kalkulator Emisji CO2</h1>
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

      <h2>Wpisy:</h2>
      <ul className="task-list">
        {taskList.map((task) => (
          <li key={task.id} className="task-item">
            <div className="task-summary">
              <span>{`${task.name} - ${task.distance} km`}</span>
              <div>
                <button onClick={() => toggleDetails(task.id)} className="toggle-button">
                    {task.detailsVisible ? 'Ukryj szczegóły' : 'Pokaż więcej'}
                </button>
                <button onClick={() => removeTask(task.id)} className="remove-button">Usuń</button>
              </div>
            </div>
            {task.detailsVisible && (
              <div className="task-details">
                <p>Emisje CO2 z transportu: {task.emissions.transportEmissions} kg</p>
                <p>Emisje CO2 z diety: {task.emissions.dietEmissions} kg</p>
                <p>Emisje CO2 z zużycia wody: {task.emissions.waterEmissions} kg</p>
                <p>Emisje CO2 z odpadów: {task.emissions.wasteEmissions} kg</p>
                <p><strong>Łączne emisje CO2: {task.emissions.totalEmissions} kg</strong></p>
              </div>
            )}
          </li>
        ))}
      </ul>
    </div>
  );
};

export default EmissionCalculator;
