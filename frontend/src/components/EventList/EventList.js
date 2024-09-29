import './EventList.scss'
import { format } from 'date-fns';

const EventList = ({ eventList }) => {
        const headers = ['Nazwa', 'Data', 'Miejsce', 'Emisja[t]']

    return (
        <div>
            <div className='event-wrapper header'>{headers.map((event, id) => <span key={id}>{event}</span>)}</div>
            {eventList.map((event, id) => (
            <div className='event-wrapper' key={id}>                 
                <span>{`${event.name}`}</span>
                <span>{`${format(event.eventDate, 'dd/MM/yyyy')}`}</span>
                <span>{`${event.place}`}</span>
                <span>{`${event.emmissionT}`}</span>
            </div>
          ))}              
        </div>
    )
}

export default EventList;