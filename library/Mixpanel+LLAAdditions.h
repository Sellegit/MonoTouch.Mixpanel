//
//  Mixpanel+LLAAdditions.h
//  Mixpanel
//
//  Created by Lukas Lipka on 27/05/14.
//  Copyright (c) 2014 Lukas Lipka. All rights reserved.
//

#import "Mixpanel.h"

@class MPSurvey;

@interface Mixpanel (LLAAdditions)

- (void)lla_checkForSurveysWithCompletion:(void (^)(NSArray *surveys))completion;
- (void)lla_showSurveyWithObject:(MPSurvey *)survey;
- (void)lla_markSurvey:(MPSurvey *)survey shown:(BOOL)shown withAnswerCount:(NSUInteger)count;

@end
