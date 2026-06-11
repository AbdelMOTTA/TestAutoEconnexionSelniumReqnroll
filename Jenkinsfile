pipeline {
    agent any

    options {
        timestamps()
    }

    stages {

        stage('Checkout') {
            steps {
                git branch: 'master',
                    url: 'https://github.com/AbdelMOTTA/TestAutoEconnexionSelniumReqnroll.git'
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
                dir /s /b allure-results || echo No allure-results found
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
                        results: [[path: 'EconnexionTestAuto/bin/Release/net8.0/allure-results']]
                    ])
                } catch (err) {
                    echo "Allure generation skipped or failed: ${err}"
                }
            }

            archiveArtifacts artifacts: '**/allure-report/**', allowEmptyArchive: true
            archiveArtifacts artifacts: '**/allure-results/**', allowEmptyArchive: true
        }

        success {
            echo "Build SUCCESS"
        }

        failure {
            echo "Build FAILED (check test logs)"
        }
    }
}
