namespace feat

module DataManipulator = 
    let GroupPathFeaturesByName (pathsFeatues:(string * FeatureToggle[])[]) =         
        //sequence comprehension
        let flatten = seq{ for (path,features) in pathsFeatues do
                                for feature in features do
                                    yield (path,feature.Name,feature.Enabled) }
        flatten
        