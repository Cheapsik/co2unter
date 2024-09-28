import { useState, useEffect } from 'react';
import './EventSector.scss';
import EventList from '../../components/EventList';

const EventSector = () => {
  const [showDetails, setShowDetails] = useState(false);
  const [showEvents, setShowEvents] = useState(false);
  const [eventData, setEventData] = useState([]);

  const toggleDetails = () => setShowDetails(!showDetails);
  const toggleEvents = () => setShowEvents(!showEvents);

  useEffect(() => {
    const fetchData = async () => {
      const response = await fetch('https://localhost:7265/api/MassEvent/all');
      const data = await response.json();
      setEventData(data);
    };
    
    fetchData();
  }, []);

  return (
    <div className="event-container">
      <h1>Emisje CO2 związane z Wydarzeniami</h1>

      <section className="description">
        <h2>Wydarzenia masowe a emisja CO2</h2>
        <p>
          Organizacja wydarzeń masowych, zarówno stacjonarnych, jak i plenerowych, generuje znaczną
          ilość emisji CO2. Wydarzenia takie jak koncerty, festiwale, targi czy konferencje wiążą
          się z transportem uczestników, użyciem energii do oświetlenia, nagłośnienia, a także
          produkcją odpadów. Każdy z tych elementów przyczynia się do wzrostu emisji gazów cieplarnianych.
        </p>
        <button className="toggle-button" onClick={toggleDetails}>
          {showDetails ? 'Ukryj szczegóły' : 'Pokaż więcej'}
        </button>
        {showDetails && (
          <div className="details">
            <p>
              Na przykład, transport uczestników do miejsca wydarzenia generuje emisję CO2, szczególnie
              jeśli dominują auta osobowe. Użycie publicznego transportu lub organizacja wspólnych dojazdów
              mogą znacznie zmniejszyć ten ślad węglowy. Dodatkowo, wydarzenia plenerowe często
              wymagają zastosowania dużej ilości jednorazowych opakowań oraz materiałów promocyjnych,
              co także wpływa na wzrost emisji.
            </p>
            <p>
              Organizatorzy mają możliwość zminimalizowania emisji, podejmując świadome decyzje,
              takie jak wybór lokalizacji, która jest łatwo dostępna komunikacją publiczną, oraz
              wprowadzenie zasad recyklingu i kompostowania odpadów. Dzięki temu mogą przyczynić się
              do zmniejszenia negatywnego wpływu na środowisko.
            </p>
          </div>
        )}
      </section>
      
      <h1>Wydarzenia</h1>
      <section className="description"> 
            <button className="toggle-button" onClick={toggleEvents}>
                {showEvents ? 'Ukryj wydarzenia' : 'Pokaż wydarzenia'}
            </button>
            {showEvents && (
              <div>
                <EventList eventList={eventData}></EventList>
              </div>
            )}
      </section>
    </div>
  );
};

export default EventSector;