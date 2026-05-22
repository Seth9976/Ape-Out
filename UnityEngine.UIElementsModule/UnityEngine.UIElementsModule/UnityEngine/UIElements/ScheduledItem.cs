using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200003C RID: 60
	public abstract class ScheduledItem
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00002E81 File Offset: 0x00001081
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00002E8E File Offset: 0x0000108E
		public long startMs
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00002E9B File Offset: 0x0000109B
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00002EA8 File Offset: 0x000010A8
		public long delayMs
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00002EB5 File Offset: 0x000010B5
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00002EC2 File Offset: 0x000010C2
		public long intervalMs
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00002ECF File Offset: 0x000010CF
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00002EDC File Offset: 0x000010DC
		public long endTimeMs
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002EE9 File Offset: 0x000010E9
		public void ResetStartTime()
		{
			this.startMs = Panel.TimeSinceStartupMs();
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002EF8 File Offset: 0x000010F8
		public void SetDuration(long durationMs)
		{
			this.endTimeMs = this.startMs + durationMs;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002F0A File Offset: 0x0000110A
		public virtual void OnItemUnscheduled()
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002F0D File Offset: 0x0000110D
		public virtual bool ShouldUnschedule()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020001A4 RID: 420
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
