import './EventList.scss'

const EventList = ({ eventList }) => {
    
    return (
        <div>  {eventList.map((event) => (
            <div>                 
              <span>{`${event.name} - ${event.place} `}</span>
            </div>
          ))}              
        </div>
    )
}

export default EventList;