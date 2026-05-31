pipeline {
    agent any

    options {
        timestamps()
    }

    stages {

        stage('Checkout') {
            steps {
                git branch: 'master',
                    url: 'https://github.com/anioua61-netizen/ReqnrollProject.git'
            }
        }

        stage('Restore') {
            steps {
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                bat 'dotnet build --configuration Release'
            }
        }

        stage('Test') {
            steps {
                bat 'dotnet test --configuration Release --logger "trx"'
            }
        }

        stage('Locate Allure Results') {
            steps {
                bat '''
                echo Searching Allure results...
                dir /s /b allure-results || echo "No allure-results in root"
                dir /s /b **\\allure-results || echo "No nested allure-results"
                '''
            }
        }
    }

    post {
        always {

            echo "=== Allure Report Generation ==="

            script {
                try {
                    allure([
                        includeProperties: false,
                        results: [[path: '**/allure-results']]
                    ])
                }
                catch (err) {
                    echo "Allure failed or no results found: ${err}"
                }
            }

            archiveArtifacts artifacts: '**/allure-report/**', allowEmptyArchive: true
            archiveArtifacts artifacts: '**/allure-results/**', allowEmptyArchive: true
        }

        failure {
            echo "Build failed - check test logs"
        }
    }
}
