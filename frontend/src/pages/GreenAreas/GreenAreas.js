import React, { useState } from 'react';
import './GreenAreas.scss';

const greenAreas = [
    { name: "Park Jordana", area: 21.50, co2Absorption: 29.00 },
    { name: "Park Krakowski", area: 25.00, co2Absorption: 35.00 },
    { name: "Ogród Botaniczny UJ", area: 7.00, co2Absorption: 10.00 },
    { name: "Park Lotników Polskich", area: 15.00, co2Absorption: 20.00 },
    { name: "Park Miejski na Błoniach", area: 15.00, co2Absorption: 20.00 },
    { name: "Park Biedronki", area: 3.00, co2Absorption: 4.50 },
    { name: "Park Lecha Kaczyńskiego", area: 8.00, co2Absorption: 11.00 },
    { name: "Park Ratuszowy", area: 2.50, co2Absorption: 3.50 },
    { name: "Skwer W. Wawel", area: 5.00, co2Absorption: 7.00 },
    { name: "Park Szwedzki", area: 6.00, co2Absorption: 8.50 },
    { name: "Park Strzelecki", area: 4.00, co2Absorption: 6.00 },
    { name: "Las Wolski", area: 30.00, co2Absorption: 42.00 },
    { name: "Tereny zielone na Krowodrzy", area: 10.00, co2Absorption: 14.00 },
    { name: "Park na Dąbiu", area: 4.50, co2Absorption: 6.00 },
    { name: "Ogród Doświadczeń", area: 1.00, co2Absorption: 1.50 },
    { name: "Tereny zielone w Nowej Hucie", area: 18.00, co2Absorption: 25.00 },
    { name: "Tereny zielone w Podgórzu", area: 12.00, co2Absorption: 16.00 },
    { name: "Park im. Stanisława Wyspiańskiego", area: 9.00, co2Absorption: 12.00 },
    { name: "Tereny zielone w rejonie Salwatora", area: 10.00, co2Absorption: 14.00 },
    { name: "Zespół Parków Krajobrazowych w Krakowie", area: 35.00, co2Absorption: 49.00 }
];

const GreenAreas = () => {
    const [selectedArea, setSelectedArea] = useState(null);

    const handleChange = (event) => {
        const selectedName = event.target.value;
        const area = greenAreas.find(g => g.name === selectedName);
        setSelectedArea(area);
    };

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
