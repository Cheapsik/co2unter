import React from 'react';
import './main.scss';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Nav from './components/Nav';
import Home from './pages/Home';
import EmissionCalculator from './pages/EmissionCalculator';
import ServiceSector from './pages/ServiceSector';
import EventSector from './pages/EventSector';
import TransportSector from './pages/TransportSector';
import EmissionConversion from './pages/EmissionConversion';
import GreenAreas from './pages/GreenAreas';

const KrakCO2 = () => {


  const sections = [
    { title: 'Kalkulator emisji CO2', component: <EmissionCalculator />},
    { title: 'Kalkulator absorbcji CO2 przez drzewa', component: <EmissionConversion />},
    { title: 'Tereny zielone', component: <GreenAreas />},
    { title: 'Sektor transportu', component: <TransportSector />},
    { title: 'Sektor usługowy', component: <ServiceSector />},
    { title: 'Sektor wydarzeń', component: <EventSector />},
  ]

  const getUrl = (title) => {
    const name = title.toLowerCase().replace(/ /g, '-')
    return `/${name}`;
  }

  return (
    <div className="App">
      <Router>
            <Nav />
            <Routes>
              <Route path="/" element={<Home />} />
                {sections.map((section, idx) => (
                  <Route
                    key={idx}
                    path={`/${getUrl(section.title)}`}
                    element={section.component}
                  />
                ))}
            </Routes>
        </Router>
    </div>
  );
}

export default KrakCO2;
