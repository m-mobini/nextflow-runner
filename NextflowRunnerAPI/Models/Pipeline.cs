﻿using System.ComponentModel.DataAnnotations.Schema;

namespace NextflowRunner.API.Models;

[Table("Pipeline")]
public record Pipeline
{
    public int PipelineId { get; set; }
    public string PipelineName { get; set; }
    public string Description { get; set; }
    public string GitHubUrl { get; set; }

    public virtual ICollection<PipelineParam> PipelineParams { get; set; }
    public virtual ICollection<PipelineRun> PipelineRuns { get; set; }
}