using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine.Profiling
{
	// Token: 0x02000277 RID: 631
	public sealed class CustomSampler : Sampler
	{
		// Token: 0x06002286 RID: 8838 RVA: 0x00012691 File Offset: 0x00010891
		public static CustomSampler Create(string name, [Optional] bool collectGpuData)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x0001269E File Offset: 0x0001089E
		public static IntPtr CreateInternal(string name, bool collectGpuData)
		{
			return CustomSampler.CreateInternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), collectGpuData);
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x000126B1 File Offset: 0x000108B1
		public void Begin()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x000126BE File Offset: 0x000108BE
		public void Begin(Object targetObject)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x000126CB File Offset: 0x000108CB
		public void End()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x000126D8 File Offset: 0x000108D8
		public static void Begin_Internal(IntPtr ptr)
		{
			CustomSampler.Begin_InternalDelegateField(ptr);
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x000126E5 File Offset: 0x000108E5
		public static void BeginWithObject_Internal(IntPtr ptr, Object targetObject)
		{
			CustomSampler.BeginWithObject_InternalDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr(targetObject));
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x000126F8 File Offset: 0x000108F8
		public static void End_Internal(IntPtr ptr)
		{
			CustomSampler.End_InternalDelegateField(ptr);
		}

		// Token: 0x04001C77 RID: 7287
		private static readonly CustomSampler.CreateInternalDelegate CreateInternalDelegateField = IL2CPP.ResolveICall<CustomSampler.CreateInternalDelegate>("UnityEngine.Profiling.CustomSampler::CreateInternal");

		// Token: 0x04001C78 RID: 7288
		private static readonly CustomSampler.Begin_InternalDelegate Begin_InternalDelegateField = IL2CPP.ResolveICall<CustomSampler.Begin_InternalDelegate>("UnityEngine.Profiling.CustomSampler::Begin_Internal");

		// Token: 0x04001C79 RID: 7289
		private static readonly CustomSampler.BeginWithObject_InternalDelegate BeginWithObject_InternalDelegateField = IL2CPP.ResolveICall<CustomSampler.BeginWithObject_InternalDelegate>("UnityEngine.Profiling.CustomSampler::BeginWithObject_Internal");

		// Token: 0x04001C7A RID: 7290
		private static readonly CustomSampler.End_InternalDelegate End_InternalDelegateField = IL2CPP.ResolveICall<CustomSampler.End_InternalDelegate>("UnityEngine.Profiling.CustomSampler::End_Internal");

		// Token: 0x02000BDB RID: 3035
		// (Invoke) Token: 0x06003610 RID: 13840
		private delegate IntPtr CreateInternalDelegate(IntPtr name, bool collectGpuData);

		// Token: 0x02000BDC RID: 3036
		// (Invoke) Token: 0x06003612 RID: 13842
		private delegate void Begin_InternalDelegate(IntPtr ptr);

		// Token: 0x02000BDD RID: 3037
		// (Invoke) Token: 0x06003614 RID: 13844
		private delegate void BeginWithObject_InternalDelegate(IntPtr ptr, IntPtr targetObject);

		// Token: 0x02000BDE RID: 3038
		// (Invoke) Token: 0x06003616 RID: 13846
		private delegate void End_InternalDelegate(IntPtr ptr);
	}
}
