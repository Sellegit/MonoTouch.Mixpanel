//
//  Mixpanel+LLAAdditions.m
//  Mixpanel
//
//  Created by Lukas Lipka on 27/05/14.
//  Copyright (c) 2014 Lukas Lipka. All rights reserved.
//

#import "Mixpanel+LLAAdditions.h"

@protocol _MixpanelPrivate <NSObject>

@property (nonatomic, strong) NSArray *surveys;
@property (nonatomic, strong) MPSurvey *currentlyShowingSurvey;

- (void)checkForSurveysWithCompletion:(void (^)(NSArray *surveys))completion;
- (void)showSurveyWithObject:(MPSurvey *)survey;
- (void)markSurvey:(MPSurvey *)survey shown:(BOOL)shown withAnswerCount:(NSUInteger)count;

@end

@implementation Mixpanel (LLAAdditions)

- (void)lla_checkForSurveysWithCompletion:(void (^)(NSArray *surveys))completion {
    id<_MixpanelPrivate> mixpanel = (id<_MixpanelPrivate>)self;
    [mixpanel checkForSurveysWithCompletion:completion];
}

- (void)lla_showSurveyWithObject:(MPSurvey *)survey {
    id<_MixpanelPrivate> mixpanel = (id<_MixpanelPrivate>)self;
    [mixpanel showSurveyWithObject:survey];
}

- (void)lla_markSurvey:(MPSurvey *)survey shown:(BOOL)shown withAnswerCount:(NSUInteger)count {
    id<_MixpanelPrivate> mixpanel = (id<_MixpanelPrivate>)self;
    [mixpanel markSurvey:survey shown:shown withAnswerCount:count];
    mixpanel.currentlyShowingSurvey = nil;
}

@end
