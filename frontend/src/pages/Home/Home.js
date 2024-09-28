import { Link } from 'react-router-dom';
import MainEmission from '../MainEmission';
import './Home.scss';

const Home = () => {
    const parseUrl = (url) => {
        const name = url.toLowerCase().replace(/ /g, '-')
        return `/${name}`;
    }

    const urls = ['Kalkulator absorbcji CO2 przez drzewa', 'Sektor transporu', 'Sektor usługowy', 'Sektor wydarzeń']
    
    return (
        <>
            <MainEmission />
            <div className="container">
                {urls.map((url) => <Link key={url} to={parseUrl(url)} className="link">{url}</Link>)}
            </div>
        </>
    );
}

export default Home;