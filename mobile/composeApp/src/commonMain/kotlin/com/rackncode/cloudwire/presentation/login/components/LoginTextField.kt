package com.rackncode.cloudwire.presentation.login.components

import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material3.TextField
import androidx.compose.material3.TextFieldDefaults
import androidx.compose.runtime.Composable
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.text.input.VisualTransformation
import androidx.compose.ui.unit.dp
import com.rackncode.cloudwire.presentation.core.inputBackground
import com.rackncode.cloudwire.presentation.core.lightBackground

@Composable
fun LoginTextField(
    value: String,
    onValueChange: (String) -> Unit,
    placeholder: @Composable () -> Unit,
    trailingIcon: @Composable () -> Unit,
    visualTransformation: VisualTransformation? = null
){
    TextField(
        value = value,
        onValueChange = onValueChange,
        shape = RoundedCornerShape(16.dp),
        colors = TextFieldDefaults.colors(
            unfocusedContainerColor = inputBackground.copy(alpha = 0.5f),
            unfocusedIndicatorColor = Color.Transparent,
            unfocusedPlaceholderColor = lightBackground.copy(alpha = 0.3f),
            unfocusedTextColor = lightBackground,
            focusedContainerColor = inputBackground.copy(alpha = 0.5f),
            focusedIndicatorColor = Color.Transparent,
            focusedPlaceholderColor = lightBackground.copy(alpha = 0.3f),
            focusedTextColor = lightBackground,
            cursorColor = inputBackground
        ),
        placeholder = placeholder,
        visualTransformation = visualTransformation?: VisualTransformation.None,
        trailingIcon = trailingIcon
    )
}