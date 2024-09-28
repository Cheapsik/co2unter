import { useState } from 'react';
import './EventSector.scss';

const EventSector = () => {
  const [showDetails, setShowDetails] = useState(false);

  const toggleDetails = () => setShowDetails(!showDetails);

  return (
    <div className="event-container">
      <h1>Emisje  CO² związane z Wydarzeniami</h1>

      <section className="description">
        <h2>Wydarzenia masowe a emisja  CO²</h2>
        <p>
          Organizacja wydarzeń masowych, zarówno stacjonarnych, jak i plenerowych, generuje znaczną
          ilość emisji  CO². Wydarzenia takie jak koncerty, festiwale, targi czy konferencje wiążą
          się z transportem uczestników, użyciem energii do oświetlenia, nagłośnienia, a także
          produkcją odpadów. Każdy z tych elementów przyczynia się do wzrostu emisji gazów cieplarnianych.
        </p>
        <button className="toggle-button" onClick={toggleDetails}>
          {showDetails ? 'Ukryj szczegóły' : 'Pokaż więcej'}
        </button>
        {showDetails && (
          <div className="details">
            <p>
              Na przykład, transport uczestników do miejsca wydarzenia generuje emisję  CO², szczególnie
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
    </div>
  );
};

export default EventSector;