import React, { useState, useEffect } from 'react';
import './EmissionList.scss';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faTrashCan } from '@fortawesome/free-solid-svg-icons';

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

    const getActivityType = (task) => {
        switch(task.activityType){
            case 'diet':
                return 'Konsumpcjonizm';
            case 'privateTransport':
                return 'Transport prywatny';
            case 'waterConsumption':
                return 'Zużycie wody';
            case 'internetConsumption':
                return 'Korzystanie z internetu';
            default:
                return '-'
        }
    }

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
                        <span>{`${task.name}`}</span>
                        <div className="action-buttons">
                            <button onClick={() => toggleDetails(task.id)} className="toggle-button">
                                {task.detailsVisible ? 'Ukryj szczegóły' : 'Pokaż więcej'}
                            </button>
                            <button onClick={() => removeTask(task.id)} className="remove-button">
                                Usuń <FontAwesomeIcon icon={faTrashCan} />
                                </button>
                        </div>
                    </div>
                    {task.detailsVisible && (
                        <div className="task-details">
                            <p>Rodzaj aktywności: <strong>{getActivityType(task)}</strong></p>
                            <p>Data utworzenia: <strong>{task.creationDate}</strong></p>
                            <p>Łączne emisje  CO₂: <strong>{task.emissions.totalEmissions} kg</strong></p>
                        </div>
                    )}
                </li>
            ))}
        </ul>
    );
};

export default EmissionList;
