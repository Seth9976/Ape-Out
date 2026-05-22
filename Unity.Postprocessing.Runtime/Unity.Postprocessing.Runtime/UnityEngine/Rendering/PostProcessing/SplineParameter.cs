using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000047 RID: 71
	[Serializable]
	public sealed class SplineParameter : ParameterOverride<Spline>
	{
		// Token: 0x060002E7 RID: 743 RVA: 0x0000EBCC File Offset: 0x0000CDCC
		// Note: this type is marked as 'beforefieldinit'.
		static SplineParameter()
		{
			Il2CppClassPointerStore<SplineParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "SplineParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplineParameter>.NativeClassPtr);
			SplineParameter.NativeMethodInfoPtr_OnEnable_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplineParameter>.NativeClassPtr, 100663518);
			SplineParameter.NativeMethodInfoPtr_SetValue_Internal_Virtual_Void_ParameterOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplineParameter>.NativeClassPtr, 100663519);
			SplineParameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Spline_Spline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplineParameter>.NativeClassPtr, 100663520);
			SplineParameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplineParameter>.NativeClassPtr, 100663521);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000EC4C File Offset: 0x0000CE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445743, XrefRangeEnd = 445744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplineParameter.NativeMethodInfoPtr_OnEnable_FamOrAssem_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000EC80 File Offset: 0x0000CE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445744, XrefRangeEnd = 445749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValue(ParameterOverride parameter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplineParameter.NativeMethodInfoPtr_SetValue_Internal_Virtual_Void_ParameterOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000ECC4 File Offset: 0x0000CEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445749, XrefRangeEnd = 445754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Interp(Spline from, Spline to, float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplineParameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Spline_Spline_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000ED28 File Offset: 0x0000CF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445754, XrefRangeEnd = 445757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SplineParameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplineParameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SplineParameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00003B18 File Offset: 0x00001D18
		public SplineParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_FamOrAssem_Virtual_Void_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Internal_Virtual_Void_ParameterOverride_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Public_Virtual_Void_Spline_Spline_Single_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
