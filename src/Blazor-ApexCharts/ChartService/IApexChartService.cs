﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApexCharts
{
    /// <summary>
    /// Service responsible for charts global options
    /// </summary>
    public interface IApexChartService
    {
        /// <summary>
        /// Charts holds the list of rendred charts
        /// </summary>
        List<IApexChartBase> Charts { get; }

        /// <summary>
        /// List all the built in locale resources
        /// </summary>
        List<LocaleResource> LocaleResources { get; }   

        /// <summary>
        /// Current global options
        /// </summary>
        IApexChartBaseOptions GlobalOptions { get; }

        /// <summary>
        /// Manually load the required javascript modules
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        Task LoadJavascriptAsync(string path = null);


        /// <summary>
        /// ReRender all charts
        /// </summary>
        /// <returns></returns>
        Task ReRenderChartsAsync();

        /// <summary>
        /// Sets the global chart options
        /// </summary>
        /// <param name="options"></param>
        /// <param name="reRenderCharts"></param>
        /// <returns></returns>
        Task SetGlobalOptionsAsync(IApexChartBaseOptions options, bool reRenderCharts);

        /// <summary>
        /// Sets the current global options
        /// </summary>
        /// <param name="reRenderCharts"></param>
        /// <returns></returns>
        Task SetGlobalOptionsAsync(bool reRenderCharts);

        /// <summary>
        /// Sets the current Locale
        /// </summary>
        /// <param name="localeResource"></param>
        /// <param name="reRenderCharts"></param>
        /// <returns></returns>
        Task SetLocaleAsync(LocaleResource localeResource, bool reRenderCharts);

        /// <summary>
        /// Sets the current locale
        /// </summary>
        /// <param name="chartLocale"></param>
        /// <param name="reRenderCharts"></param>
        /// <returns></returns>
        Task SetLocaleAsync(ChartLocale chartLocale, bool reRenderCharts);
          

        internal Task GlobalOptionsInitializedAsync();
        internal void RegisterChart(IApexChartBase apexChart);
        internal void UnRegisterChart(IApexChartBase apexChart);
    }
}