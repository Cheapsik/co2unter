import { Link } from 'react-router-dom';
import DataSource from '../DataSource';


const Home = () => {

    const parseUrl = (url) => {
        const name = url.toLowerCase().replace(/ /g, '-')
        return `/${name}`;
      }

    const urls = ['Indywidualne działania mieszkańców', 'Transport', 'Sektor usługowy', 'Wydarzenia']
    
    return (
        <div className="container">
            {urls.map((url) => <Link key={url} to={parseUrl(url)} className="link">{url}</Link>)}
            <DataSource>

            </DataSource>
        </div>
    );
}

export default Home;