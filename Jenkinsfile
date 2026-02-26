pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                git 'https://github.com/dansteamer1337-lab/TEST.git'
            }
        }

        stage('Restore') {
            steps {
                sh 'dotnet restore'
            }
        }
        stage('Build') {
            steps {
                sh 'dotnet build --no-restore'
            }
        }

        stage('Test') {
            steps {
                sh 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}