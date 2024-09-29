import React, { useEffect, useState } from 'react';
import './MainEmission.scss';
import EmissionList from '../../components/EmissionList/EmissionList';
import { useNavigate } from 'react-router-dom';
import { CircularProgressbar, buildStyles } from 'react-circular-progressbar';
import 'react-circular-progressbar/dist/styles.css';

const MainEmission = () => {
    const [taskList, setTaskList] = useState([]);
    const [totalCO2, setTotalCO2] = useState(0);
    const navigate = useNavigate();
    const monthlyLimit = 350;

    useEffect(() => {
        const storedTasks = JSON.parse(localStorage.getItem('tasks')) || [];
        setTaskList(storedTasks);
        calculateTotalCO2(storedTasks);
    }, []);

    const goTo = () => {
        navigate('/kalkulator-emisji-CO₂');
    }

    const calculateTotalCO2 = (tasks) => {
        const co2 = tasks.reduce((acc, task) => acc + Number(task.emissions.totalEmissions), 0);
        setTotalCO2(co2);
    };

    const progressPercentage = Math.min((totalCO2 / monthlyLimit) * 100, 100);

    return (
        <div className="summary-container">
            <h1>Dzień dobry</h1>
            <h2>Podsumowanie Twoich emisji z tego miesiąca</h2>
            
            <div className="circle-progress">
                <CircularProgressbar
                    value={progressPercentage}
                    text={`${totalCO2.toFixed(2)}kg CO₂`}
                    maxValue={100}
                    styles={buildStyles({
                        pathColor: '#4caf50',
                        trailColor: '#d6d6d6',
                        strokeLinecap: 'round',
                        textColor: '#4caf50'
                    })}
                />
            </div>

            <button className="redirect-button" onClick={goTo}>Dodaj emisję  CO₂</button>

            <div className="recent-journeys">
                <h3>Ostatnie</h3>
                {taskList.length === 0 ? (
                    <p>Brak ostatnich emisji.</p>
                ) : (
                    <div className="emission-list">
                        <EmissionList taskList={taskList} />
                    </div>
                )}
            </div>
        </div>
    );
};

export default MainEmission;
