import { format } from 'date-fns';
import './EventList.scss'

const EventList = ({ eventList }) => {
        const headers = ['Nazwa', 'Miejsce', 'Emisja (t)', 'Data']

    return (
        <div>
            <div className='event-wrapper header'>{headers.map((event, id) => <span key={id}>{event}</span>)}</div>
            {eventList.map((event, id) => (
            <div className='event-wrapper' key={id}>                 
                <span>{`${event.name}`}</span>
                <span>{`${event.place}`}</span>
                <span>{`${event.emmissionT}`}</span>
                <span className="gray">{`${format(event.eventDate, 'dd/MM/yyyy')}`}</span>
            </div>
          ))}              
        </div>
    )
}

export default EventList;