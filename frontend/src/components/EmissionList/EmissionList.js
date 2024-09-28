import React, { useState, useEffect } from 'react';
import './EmissionList.scss';

const EmissionList = ({ taskList }) => {
    const [tasks, setTasks] = useState([]);


    useEffect(() => {
        setTasks(taskList);
    }, [taskList]);

    const toggleDetails = (id) => {
        const updatedTasks = tasks.map((task) => {
            if (task.id === id) {
                return {
                    ...task,
                    detailsVisible: !task.detailsVisible,
                };
            }
            return task;
        });
        setTasks(updatedTasks);
    };

    const removeTask = (id) => {
        const updatedTasks = tasks.filter((task) => task.id !== id);
        setTasks(updatedTasks);
        localStorage.setItem('tasks', JSON.stringify(updatedTasks)); 
    };

    return (
        <ul className="task-list">
            {tasks.map((task) => (
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
                            <p>Emisje  CO₂ z transportu: {task.emissions.transportEmissions} kg</p>
                            <p>Emisje  CO₂ z diety: {task.emissions.dietEmissions} kg</p>
                            <p>Emisje  CO₂ z zużycia wody: {task.emissions.waterEmissions} kg</p>
                            <p>Emisje  CO₂ z odpadów: {task.emissions.wasteEmissions} kg</p>
                            <p><strong>Łączne emisje  CO₂: {task.emissions.totalEmissions} kg</strong></p>
                        </div>
                    )}
                </li>
            ))}
        </ul>
    );
};

export default EmissionList;
