using Microsoft.Extensions.Logging;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ILogger = Microsoft.Extensions.Logging.ILogger;

public abstract class CoolScript : MonoBehaviour
{
    protected abstract ILogger Logger { get; }
    public void Execute()
    {
        this.Logger.LogInformation("Cool script was executed.");
    }
}
