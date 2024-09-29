import { Link } from 'react-router-dom';
import MainEmission from '../MainEmission';
import DataSource from '../DataSource';
import './Home.scss';

const urlList = [
    'Kalkulator absorpcji CO₂ przez drzewa',
    'Tereny zielone',
    'Sektor transportu',
    'Sektor usługowy',
    'Sektor wydarzeń'
];

const parseUrl = (url) => `/${url.toLowerCase().replace(/ /g, '-')}`;

const Home = () => (
    <>
        <MainEmission />
            <div className="container">
                {urlList.map((url) => (
                    <Link key={url} to={parseUrl(url)} className="link">
                        {url}
                    </Link>
                ))}
            </div>
        <DataSource />
    </>
);

export default Home;
