//
//  WeatherGadget.h
//  WeatherGadget
//
//  Created by Christiaan van Wyk on 2017/10/10.
//  Copyright © 2017 Xamarin. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "Weather.h"

//! Project version number for WeatherGadget.
FOUNDATION_EXPORT double WeatherGadgetVersionNumber;

//! Project version string for WeatherGadget.
FOUNDATION_EXPORT const unsigned char WeatherGadgetVersionString[];

typedef void(^result)(BOOL);

// I am going to call these methods on you...
@protocol WeatherGadgetDelegate <NSObject>

@required
- (void) didFetchWeather:(Weather *)weather;

@optional
- (void) didRaiseBuzzer;
- (void) didCancelBuzzer;
- (void) didLightLED;
- (void) didCancelLED;

@end

// this is where you register yourself with me
@interface WeatherGadget : NSObject

- (void) pollSensors:(result) execute;
- (void) fetchWeather;
- (NSMutableArray*) fetchHistoricWeather;
- (void) raiseBuzzer:(BOOL) status;
- (void) lightLED:(BOOL) status;

@property double calibrationOffset;

@property (nonatomic, weak) id <WeatherGadgetDelegate> delegate;

@end
