import React, { useState, useEffect } from 'react';
import './GreenAreas.scss'; // Zadbaj o odpowiednie style

const GreenAreas = () => {
    const [selectedArea, setSelectedArea] = useState(null);
    const [greenAreas, setGreenAreas] = useState([]);

    const handleChange = (event) => {
        const selectedName = event.target.value;
        const area = greenAreas.find(g => g.name === selectedName);
        setSelectedArea(area);
    };
  
    useEffect(() => {
      const fetchData = async () => {
        const response = await fetch(`${process.env.REACT_APP_API_URL??'https://krakco2.pl/api/'}GreenArea`);
        const data = await response.json();
        setGreenAreas(data);
      };
      
      fetchData();
    }, []);

    return (
        <div className="green-area-selector">
            <h2>Wybierz teren zielony w Krakowie</h2>
            <select onChange={handleChange} defaultValue="">
                <option value="" disabled>Wybierz park/teren</option>
                {greenAreas.map((area) => (
                    <option key={area.name} value={area.name}>{area.name}</option>
                ))}
            </select>
            {selectedArea && (
                <div className="area-info">
                    <h3>{selectedArea.name}</h3>
                    <p>Powierzchnia: {selectedArea.area}ha</p>
                    <p>Pochłanianie CO₂: {selectedArea.co2Absorption} ton rocznie</p>
                </div>
            )}
        </div>
    );
};

export default GreenAreas;
