const Footer = () => {
  return (
    <footer className="bg-white shadow-lg">
      <div className="max-w-7xl mx-auto py-4 px-4">
        <p className="text-center text-gray-600">
          © {new Date().getFullYear()} Bağış Takip Sistemi. Tüm hakları saklıdır.
        </p>
      </div>
    </footer>
  )
}

export default Footer