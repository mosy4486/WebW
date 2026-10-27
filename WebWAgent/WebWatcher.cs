using System;
using System.Collections.Generic;
using System.Text;
using WebWC;

namespace WebWAgent
{
    public class WebWatcher
    {
        public async Task<(WebDataStruct data, bool success)> GetWebDataAsync(CancellationToken token)
        {
            return (new WebDataStruct(), false);

            while (!token.IsCancellationRequested)
            { 
                
            
            
            }
        }

    }
}
