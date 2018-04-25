//
//  WeatherGadget.m
//  WeatherGadget
//
//  Created by Chris van Wyk on 2017/02/17.
//  Copyright © 2017 Chris van Wyk. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "WeatherGadget.h"

@implementation WeatherGadget

-(id)init {
    if ( self = [super init] ) {
    }
    return self;
}

-(void)fetchWeather {
    // fake weather for now
    Weather *weather = [[Weather alloc] init];
    weather.currentTemperature = -20.0 + _calibrationOffset;
    
    if ([self.delegate respondsToSelector:@selector(didFetchWeather:)]) {
        [self.delegate didFetchWeather:weather];
    }
}

- (NSMutableArray*) fetchHistoricWeather{
    NSMutableArray *historicTemp = [[NSMutableArray alloc] init];
    
    
    
    return historicTemp;
}

- (void) raiseBuzzer:(BOOL) status {
    if (status == YES){
        if ([self.delegate respondsToSelector:@selector(didRaiseBuzzer)]) {
            [self.delegate didRaiseBuzzer];
        }
    } else {
        if ([self.delegate respondsToSelector:@selector(didCancelBuzzer)]) {
            [self.delegate didCancelBuzzer];
        }
    }
}

- (void) lightLED:(BOOL)status {
    if (status == YES){
        if ([self.delegate respondsToSelector:@selector(didLightLED)]) {
            [self.delegate didLightLED];
        }
    } else {
        if ([self.delegate respondsToSelector:@selector(didCancelLED)]) {
            [self.delegate didCancelLED];
        }
    }
}

-(void) myMethod:(result) compblock{
    //do stuff
    compblock(YES);
}

- (void) pollSensors:(result) execute{
    
    dispatch_queue_t myQueue = dispatch_queue_create("My Queue",NULL);
    dispatch_async(myQueue, ^{
        _calibrationOffset = 5;
        // Perform long running process
        for (int i = 1; i <= 10; i++)
        {
            [NSThread sleepForTimeInterval:0.2f];
            NSLog(@"%d", i);
        }
        dispatch_async(dispatch_get_main_queue(), ^{
            // Update the UI
            execute(YES);
        });
    });
}
@end

