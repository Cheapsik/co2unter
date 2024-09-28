import React, { useState } from 'react';
import './EmissionConversion.scss'; // Upewnij się, że masz odpowiednie style

const EmissionConversion = () => {
    const [treeType, setTreeType] = useState('');
    const [co2Amount, setCo2Amount] = useState('');
    const [absorpcjonData, setAbsorpcjonData] = useState('');

    const handleChange = (event) => {
        setTreeType(event.target.value);
    };

    const handleCo2Change = (event) => {
        setCo2Amount(event.target.value);
    };
    
    const timeMapper = (timeString) => {
        if (timeString.includes('.')) {
            const [daysString, time] = timeString.split('.');
            const days = parseInt(daysString, 10);
            const [hours] = time.split(':').map(Number);

            return `${days} dni, ${hours} godzin`;
        } else {
            const [hours] = timeString.split(':').map(Number);

            return `${hours} godzin`;
        }
    };

    const handleSubmit = async (event) => {
        event.preventDefault();
        try {
            const response = await fetch(`https://krakco2.pl/api/TreeEmissionEffectivityCalculator/Calculate/Time/${treeType}?co2weight=${co2Amount}`);
            const data = await response.json();
            const time = timeMapper(data)
            setAbsorpcjonData(time);
            return data;
        } catch (error) {
            throw new Error(error)
        }
    };

    return (
        <div className="emission-conversion-container">  
            <h1>Kalkulator Pochłaniania CO₂ przez Drzewa</h1>
            <div className="tree-calculator-container">
                <form className="calculator-form" onSubmit={handleSubmit}>
                    <label htmlFor="tree-type">Typ Drzewa:</label>
                    <select id="tree-type" value={treeType} onChange={handleChange} required>
                        <option value="" disabled>Wybierz typ drzewa</option>
                        <option value="3">100-letnie drzewo</option>
                        <option value="2">Średnie drzewo (20-30 lat)</option>
                        <option value="1">Mała sadzonka</option>
                    </select>

                    <label htmlFor="co2-amount">Ilość CO2 (w gramach):</label>
                    <input
                        type="number"
                        id="co2-amount"
                        value={co2Amount}
                        onChange={handleCo2Change}
                        min="0"
                        required
                    />

                    <button type="submit" className="calculate-button">Oblicz</button>

                    {absorpcjonData && <span>Czas: {absorpcjonData}</span> }
                </form>
            </div>
        </div>
    );
};

export default EmissionConversion;
