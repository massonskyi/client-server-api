This README file provides instructions on how to run the FastAPI application and the client application.

## Running the FastAPI application

1. Clone the repository.
2. Navigate to the `api` directory.
3. Create a virtual environment and activate it.
4. Install the dependencies by running the following command:

```sh
pip install -r requirements.txt
```

5. Run the application by running the following command:

```sh
uvicorn main:app --host 127.0.0.1 --port 8001
```

The application will now be running on port 8001. You can access it by visiting the following URL in your browser:

```ini
http://127.0.0.1:8001/
```

## Running the client application

1. Clone the repository.
2. Navigate to the `client_api` directory.
3. Create a virtual environment and activate it.
4. Install the dependencies by running the following command:

```sh
pip install -r requirements.txt
```

5. Run the application by running the following command:

```sh
dotnet run 
```

The application will now make a request to the FastAPI application and print the response to the console.