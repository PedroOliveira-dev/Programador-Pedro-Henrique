<!DOCTYPE html>
<html>
<head>
    <title>User Report</title>
</head>
<body>
    <table id="userTable">
        <thead>
            <tr>
                <th>Id</th>
                <th>Name</th>
                <th>Email</th>
                <th>Username</th>
                <th>Gender</th>
                <th>Date of Birth</th>
                <th>Country</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody></tbody>
    </table>
    <script>
        async function loadUsers() {
            const response = await fetch('/api/users');
            const users = await response.json();
            const tableBody = document.querySelector('#userTable tbody');
            users.forEach(user => {
                const row = document.createElement('tr');
                row.innerHTML = `
                    <td>${user.Id}</td>
                    <td>${user.FirstName} ${user.LastName}</td>
                    <td>${user.Email}</td>
                    <td>${user.Username}</td>
                    <td>${user.Gender}</td>
                    <td>${new Date(user.DateOfBirth).toLocaleDateString()}</td>
                    <td>${user.Country}</td>
                    <td><button onclick="editUser(${user.Id})">Edit</button></td>
                `;
                tableBody.appendChild(row);
            });
        }

        function editUser(userId) {
            // Função para editar usuário
        }

        loadUsers();
    </script>
</body>
</html>
