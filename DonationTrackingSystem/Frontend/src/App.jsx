import { BrowserRouter } from 'react-router-dom'
import AppRouter from './routes/AppRouter'
import Navbar from './components/Navbar'
import Sidebar from './components/Sidebar'
import Footer from './components/Footer'

function App() {
  return (
    <BrowserRouter>
      <div className="flex h-screen bg-gray-100">
        <Sidebar />
        <div className="flex-1 flex flex-col overflow-hidden">
          <Navbar />
          <main className="flex-1 overflow-x-hidden overflow-y-auto bg-gray-200 p-4">
            <AppRouter />
          </main>
          <Footer />
        </div>
      </div>
    </BrowserRouter>
  )
}

export default App