package com.rackncode.cloudwire

import android.app.Application
import com.rackncode.cloudwire.di.initKoin
import org.koin.android.ext.koin.androidContext

class CloudWireApp: Application() {

    override fun onCreate() {
        super.onCreate()
        initKoin {
            androidContext(this@CloudWireApp)
        }
    }
}