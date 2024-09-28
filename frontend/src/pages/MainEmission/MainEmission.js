import React, { useEffect, useState } from 'react';
import './MainEmission.scss';
import EmissionList from '../../components/EmissionList/EmissionList';
import { useNavigate } from 'react-router-dom';

const MainEmission = () => {
    const [taskList, setTaskList] = useState([]);
    const [totalCO2, setTotalCO2] = useState(0); 
    const navigate = useNavigate();

    const weeklyAllowance = 400;
    const mostUsedMobility = 'Bicycle';
    const savedCO2 = '10 cars off the road';

    useEffect(() => {
        const storedTasks = JSON.parse(localStorage.getItem('tasks')) || [];
        setTaskList(storedTasks);
        calculateTotalCO2(storedTasks);
    }, []);

    const goTo = () => {
        navigate('/kalkulator-emisji-co2');
    }

    const calculateTotalCO2 = (tasks) => {
        const total = tasks.reduce((acc, task) => {
            let transportEmissions = 0;
            if (task.transportType === 'car') {
                transportEmissions = task.distance * 0.2;
            } else if (task.transportType === 'public transport') {
                transportEmissions = task.distance * 0.05;
            } else if (task.transportType === 'bike' || task.transportType === 'walking') {
                transportEmissions = 0
            }

            let dietEmissions = 0;
            if (task.dietType === 'meat') {
                dietEmissions = 2.5;
            } else if (task.dietType === 'vegetarian') {
                dietEmissions = 1.5;
            } else if (task.dietType === 'vegan') {
                dietEmissions = 1;
            } else if (task.dietType === 'mediterranean') {
                dietEmissions = 1.2;
            }

            const waterEmissions = task.waterUsage * 0.02;
            const wasteEmissions = task.waste * 0.5;

            return acc + transportEmissions + dietEmissions + waterEmissions + wasteEmissions;
        }, 0);

        setTotalCO2(total.toFixed(2));
    };
      
    return (
        <div className="summary-container">
            <h1>Witaj,</h1>
            <h2>Oto podsumowanie twoich emisji</h2>
            <div className="circle">
                <div className="co2-value">{totalCO2}kg</div>
                <div className="co2-text">CO₂</div>
                <div className="subtext">So far this week</div>
            </div>
            <div className="info">
                <div className="mobility">
                    <span>🚲</span>
                    <span>{mostUsedMobility}</span>
                </div>
                <div className="change">-7.6%</div>
                <div className="weekly-allowance">{weeklyAllowance}kg Weekly allowance</div>
            </div>
            <button className="redirect-button" onClick={goTo}>Dodaj emisję CO2</button>
            <div className="recent-journeys">
                <h3>Ostatnie podróże</h3>
                {taskList.length === 0 ? (
                    <p>Brak ostatnich podróży.</p>
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
