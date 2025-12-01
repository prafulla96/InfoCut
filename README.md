2. **Open the solution in Visual Studio 2022.**
3. **Restore NuGet packages:**
- Visual Studio will prompt to restore packages on project load.
4. **Update database:**
- Open the Package Manager Console and run:
  ```sh
  Update-Database
  ```
- Ensure your connection string in `appsettings.json` is configured for your environment.

### Running the Application

- Press `F5` or click __Start Debugging__ in Visual Studio.
- The application will launch in your default browser.

## Project Structure

- `Controllers/` – MVC controllers (e.g., `HomeController`)
- `Models/` – Entity Framework models
- `Views/` – Razor views for each page
- `Data/` – Database context (`ApplicationDbContext`)
- `wwwroot/` – Static files

## Contributing

Please see the `CONTRIBUTING.md` for coding standards and contribution guidelines.

## License

This project is licensed under the MIT License.

## Contact

For questions or feedback, use the Contact Us page in the application or open an issue on GitHub.
