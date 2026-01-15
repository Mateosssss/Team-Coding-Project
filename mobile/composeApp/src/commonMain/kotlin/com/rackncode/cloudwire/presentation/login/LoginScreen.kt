package com.rackncode.cloudwire.presentation.login

import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.size
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.Visibility
import androidx.compose.material.icons.outlined.Email
import androidx.compose.material3.Button
import androidx.compose.material3.ButtonDefaults
import androidx.compose.material3.Icon
import androidx.compose.material3.IconButton
import androidx.compose.material3.MaterialTheme
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.draw.clip
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.text.input.PasswordVisualTransformation
import androidx.compose.ui.text.style.TextAlign
import androidx.compose.ui.text.style.TextDecoration
import androidx.compose.ui.unit.dp
import cloudwire.composeapp.generated.resources.Res
import cloudwire.composeapp.generated.resources.email
import cloudwire.composeapp.generated.resources.email_placeholder
import cloudwire.composeapp.generated.resources.forgot_password
import cloudwire.composeapp.generated.resources.ic_app_logo
import cloudwire.composeapp.generated.resources.log_in
import cloudwire.composeapp.generated.resources.login_sub_header
import cloudwire.composeapp.generated.resources.login_welcome
import cloudwire.composeapp.generated.resources.logo_description
import cloudwire.composeapp.generated.resources.password
import cloudwire.composeapp.generated.resources.password_placeholder
import com.rackncode.cloudwire.presentation.core.darkBackground
import com.rackncode.cloudwire.presentation.core.inputBackground
import com.rackncode.cloudwire.presentation.core.lightBackground
import com.rackncode.cloudwire.presentation.core.panels
import com.rackncode.cloudwire.presentation.login.components.LoginTextField
import org.jetbrains.compose.resources.painterResource
import org.jetbrains.compose.resources.stringResource
import org.jetbrains.compose.ui.tooling.preview.Preview

@Composable
fun LoginScreen(
    onLoginClick: (String, String) -> Unit,
    onForgotPasswordClick: () -> Unit
){
    var emailText by remember { mutableStateOf("") }
    var passwordText by remember { mutableStateOf("") }

    Scaffold(
        containerColor = darkBackground,
        contentColor = lightBackground
    )
    { paddingValues ->
        Column(
            modifier = Modifier
                .fillMaxSize()
                .padding(paddingValues)
                .padding(
                    vertical = 16.dp,
                    horizontal = 16.dp
                ),
            horizontalAlignment = Alignment.CenterHorizontally,
            verticalArrangement = Arrangement.spacedBy(16.dp),
        ){
            Icon(
                painter = painterResource(Res.drawable.ic_app_logo),
                contentDescription = stringResource(Res.string.logo_description),
                tint = Color.Unspecified,
                modifier = Modifier
                    .size(124.dp)
            )
            Text(
                text = stringResource(Res.string.login_welcome),
                style = MaterialTheme.typography.headlineMedium,
                fontWeight = FontWeight.Bold,
                textAlign = TextAlign.Center
            )
            Text(
                text = stringResource(Res.string.login_sub_header),
                style = MaterialTheme.typography.bodyLarge,
                textAlign = TextAlign.Center
            )
            Spacer(Modifier.size(16.dp))
            Column(
                modifier = Modifier
                    .clip(RoundedCornerShape(16.dp))
                    .background(color = panels.copy(alpha = 0.16f))
                    .padding(32.dp)
            ) {
                Text(
                    text = stringResource(Res.string.email),
                    style = MaterialTheme.typography.labelLarge
                )
                LoginTextField(
                    value = emailText,
                    onValueChange = {
                        emailText = it
                    },
                    placeholder = {
                        Text(
                            text = stringResource(Res.string.email_placeholder)
                        )
                    },
                    trailingIcon = {
                        Icon(
                            imageVector = Icons.Outlined.Email,
                            contentDescription = null,
                            tint = lightBackground
                        )
                    }
                )
                Spacer(Modifier.size(16.dp))
                Text(
                    text = stringResource(Res.string.password),
                    style = MaterialTheme.typography.labelLarge
                )
                LoginTextField(
                    value = passwordText,
                    onValueChange = {
                        passwordText = it
                    },
                    placeholder = {
                        Text(
                            text = stringResource(Res.string.password_placeholder)
                        )
                    },
                    trailingIcon = {
                        IconButton(
                            onClick = {}
                        ){
                            Icon(
                                imageVector = Icons.Default.Visibility,
                                contentDescription = stringResource(Res.string.password_placeholder),
                                tint = lightBackground
                            )
                        }
                    },
                    visualTransformation = PasswordVisualTransformation()
                )
            }
            Spacer(Modifier.size(16.dp))
            Button(
                onClick = {
                    onLoginClick("", "")
                },
                colors = ButtonDefaults.buttonColors(
                    containerColor = inputBackground
                ),
                shape = RoundedCornerShape(16.dp),
                modifier = Modifier
                    .size(width = 192.dp, height = 48.dp)
            ){
                Text(
                    text = stringResource(Res.string.log_in).uppercase(),
                    fontWeight = FontWeight.Bold,
                    style = MaterialTheme.typography.bodyLarge
                )
            }
            Text(
                text = stringResource(Res.string.forgot_password),
                textDecoration = TextDecoration.Underline,
                modifier = Modifier
                    .clickable{
                        onForgotPasswordClick()
                    }
            )
        }
    }
}

@Preview
@Composable
fun LoginPreview(){
    MaterialTheme {
        LoginScreen(
            onLoginClick = {email, password ->

            },
            onForgotPasswordClick = {}
        )
    }
}