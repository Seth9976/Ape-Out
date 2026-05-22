using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Profiling
{
	// Token: 0x02000275 RID: 629
	public sealed class Recorder
	{
		// Token: 0x06002268 RID: 8808 RVA: 0x000124E6 File Offset: 0x000106E6
		public override void Finalize()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x000124F3 File Offset: 0x000106F3
		public static Recorder Get(string samplerName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x00012500 File Offset: 0x00010700
		public static IntPtr GetInternal(string samplerName)
		{
			return Recorder.GetInternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(samplerName));
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x0600226B RID: 8811 RVA: 0x00012512 File Offset: 0x00010712
		public bool isValid
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x0001251F File Offset: 0x0001071F
		public static void DisposeNative(IntPtr ptr)
		{
			Recorder.DisposeNativeDelegateField(ptr);
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x000781A0 File Offset: 0x000763A0
		// (set) Token: 0x0600226E RID: 8814 RVA: 0x000781C4 File Offset: 0x000763C4
		public bool enabled
		{
			get
			{
				return this.isValid && this.IsEnabled();
			}
			set
			{
				bool isValid = this.isValid;
				if (isValid)
				{
					this.SetEnabled(value);
				}
			}
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x0001252C File Offset: 0x0001072C
		public bool IsEnabled()
		{
			return Recorder.IsEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x0001253E File Offset: 0x0001073E
		public void SetEnabled(bool enabled)
		{
			Recorder.SetEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), enabled);
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06002271 RID: 8817 RVA: 0x000781E4 File Offset: 0x000763E4
		public long elapsedNanoseconds
		{
			get
			{
				return this.isValid ? this.GetElapsedNanoseconds() : 0L;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06002272 RID: 8818 RVA: 0x00078208 File Offset: 0x00076408
		public long gpuElapsedNanoseconds
		{
			get
			{
				return this.isValid ? this.GetGpuElapsedNanoseconds() : 0L;
			}
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x00012551 File Offset: 0x00010751
		public long GetElapsedNanoseconds()
		{
			return Recorder.GetElapsedNanosecondsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x00012563 File Offset: 0x00010763
		public long GetGpuElapsedNanoseconds()
		{
			return Recorder.GetGpuElapsedNanosecondsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06002275 RID: 8821 RVA: 0x0007822C File Offset: 0x0007642C
		public int sampleBlockCount
		{
			get
			{
				return this.isValid ? this.GetSampleBlockCount() : 0;
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06002276 RID: 8822 RVA: 0x00078250 File Offset: 0x00076450
		public int gpuSampleBlockCount
		{
			get
			{
				return this.isValid ? this.GetGpuSampleBlockCount() : 0;
			}
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x00012575 File Offset: 0x00010775
		public int GetSampleBlockCount()
		{
			return Recorder.GetSampleBlockCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x00012587 File Offset: 0x00010787
		public int GetGpuSampleBlockCount()
		{
			return Recorder.GetGpuSampleBlockCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x00012599 File Offset: 0x00010799
		public void FilterToCurrentThread()
		{
			Recorder.FilterToCurrentThreadDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x000125AB File Offset: 0x000107AB
		public void CollectFromAllThreads()
		{
			Recorder.CollectFromAllThreadsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x04001C69 RID: 7273
		private static readonly Recorder.GetInternalDelegate GetInternalDelegateField = IL2CPP.ResolveICall<Recorder.GetInternalDelegate>("UnityEngine.Profiling.Recorder::GetInternal");

		// Token: 0x04001C6A RID: 7274
		private static readonly Recorder.DisposeNativeDelegate DisposeNativeDelegateField = IL2CPP.ResolveICall<Recorder.DisposeNativeDelegate>("UnityEngine.Profiling.Recorder::DisposeNative");

		// Token: 0x04001C6B RID: 7275
		private static readonly Recorder.IsEnabledDelegate IsEnabledDelegateField = IL2CPP.ResolveICall<Recorder.IsEnabledDelegate>("UnityEngine.Profiling.Recorder::IsEnabled");

		// Token: 0x04001C6C RID: 7276
		private static readonly Recorder.SetEnabledDelegate SetEnabledDelegateField = IL2CPP.ResolveICall<Recorder.SetEnabledDelegate>("UnityEngine.Profiling.Recorder::SetEnabled");

		// Token: 0x04001C6D RID: 7277
		private static readonly Recorder.GetElapsedNanosecondsDelegate GetElapsedNanosecondsDelegateField = IL2CPP.ResolveICall<Recorder.GetElapsedNanosecondsDelegate>("UnityEngine.Profiling.Recorder::GetElapsedNanoseconds");

		// Token: 0x04001C6E RID: 7278
		private static readonly Recorder.GetGpuElapsedNanosecondsDelegate GetGpuElapsedNanosecondsDelegateField = IL2CPP.ResolveICall<Recorder.GetGpuElapsedNanosecondsDelegate>("UnityEngine.Profiling.Recorder::GetGpuElapsedNanoseconds");

		// Token: 0x04001C6F RID: 7279
		private static readonly Recorder.GetSampleBlockCountDelegate GetSampleBlockCountDelegateField = IL2CPP.ResolveICall<Recorder.GetSampleBlockCountDelegate>("UnityEngine.Profiling.Recorder::GetSampleBlockCount");

		// Token: 0x04001C70 RID: 7280
		private static readonly Recorder.GetGpuSampleBlockCountDelegate GetGpuSampleBlockCountDelegateField = IL2CPP.ResolveICall<Recorder.GetGpuSampleBlockCountDelegate>("UnityEngine.Profiling.Recorder::GetGpuSampleBlockCount");

		// Token: 0x04001C71 RID: 7281
		private static readonly Recorder.FilterToCurrentThreadDelegate FilterToCurrentThreadDelegateField = IL2CPP.ResolveICall<Recorder.FilterToCurrentThreadDelegate>("UnityEngine.Profiling.Recorder::FilterToCurrentThread");

		// Token: 0x04001C72 RID: 7282
		private static readonly Recorder.CollectFromAllThreadsDelegate CollectFromAllThreadsDelegateField = IL2CPP.ResolveICall<Recorder.CollectFromAllThreadsDelegate>("UnityEngine.Profiling.Recorder::CollectFromAllThreads");

		// Token: 0x02000BCD RID: 3021
		// (Invoke) Token: 0x060035F4 RID: 13812
		private delegate IntPtr GetInternalDelegate(IntPtr samplerName);

		// Token: 0x02000BCE RID: 3022
		// (Invoke) Token: 0x060035F6 RID: 13814
		private delegate void DisposeNativeDelegate(IntPtr ptr);

		// Token: 0x02000BCF RID: 3023
		// (Invoke) Token: 0x060035F8 RID: 13816
		private delegate bool IsEnabledDelegate(IntPtr @this);

		// Token: 0x02000BD0 RID: 3024
		// (Invoke) Token: 0x060035FA RID: 13818
		private delegate void SetEnabledDelegate(IntPtr @this, bool enabled);

		// Token: 0x02000BD1 RID: 3025
		// (Invoke) Token: 0x060035FC RID: 13820
		private delegate long GetElapsedNanosecondsDelegate(IntPtr @this);

		// Token: 0x02000BD2 RID: 3026
		// (Invoke) Token: 0x060035FE RID: 13822
		private delegate long GetGpuElapsedNanosecondsDelegate(IntPtr @this);

		// Token: 0x02000BD3 RID: 3027
		// (Invoke) Token: 0x06003600 RID: 13824
		private delegate int GetSampleBlockCountDelegate(IntPtr @this);

		// Token: 0x02000BD4 RID: 3028
		// (Invoke) Token: 0x06003602 RID: 13826
		private delegate int GetGpuSampleBlockCountDelegate(IntPtr @this);

		// Token: 0x02000BD5 RID: 3029
		// (Invoke) Token: 0x06003604 RID: 13828
		private delegate void FilterToCurrentThreadDelegate(IntPtr @this);

		// Token: 0x02000BD6 RID: 3030
		// (Invoke) Token: 0x06003606 RID: 13830
		private delegate void CollectFromAllThreadsDelegate(IntPtr @this);
	}
}
