pipeline {
    agent any

    stages {
        stage('Restore') {
            steps {
                sh 'dotnet restore SimpleApp.sln'
            }
        }

        stage('Build') {
            steps {
                sh 'dotnet build SimpleApp.sln --no-restore'
            }
        }

        stage('Test') {
            steps {
                sh 'dotnet test SimpleApp.sln --no-build'
            }
        }
    }
}