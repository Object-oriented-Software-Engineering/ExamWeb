import ReactDOM from 'react-dom/client';
import 'semantic-ui-css/semantic.min.css'
import './styles.css';
import reportWebVitals from './reportWebVitals';
import { RouterProvider } from 'react-router-dom';
import { router } from './app/router/Routes';

const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);
root.render(
  <RouterProvider router={router} />
);
reportWebVitals();
