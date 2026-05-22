using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Timeline
{
	// Token: 0x02000020 RID: 32
	public class RuntimeClipBase : RuntimeElement
	{
		// Token: 0x0600036A RID: 874 RVA: 0x00011F2C File Offset: 0x0001012C
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeClipBase()
		{
			Il2CppClassPointerStore<RuntimeClipBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "RuntimeClipBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeClipBase>.NativeClassPtr);
			RuntimeClipBase.NativeMethodInfoPtr_get_start_Public_Abstract_Virtual_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClipBase>.NativeClassPtr, 100663888);
			RuntimeClipBase.NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClipBase>.NativeClassPtr, 100663889);
			RuntimeClipBase.NativeMethodInfoPtr_get_intervalStart_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClipBase>.NativeClassPtr, 100663890);
			RuntimeClipBase.NativeMethodInfoPtr_get_intervalEnd_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClipBase>.NativeClassPtr, 100663891);
			RuntimeClipBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClipBase>.NativeClassPtr, 100663892);
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00011FC0 File Offset: 0x000101C0
		public unsafe virtual double start
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeClipBase.NativeMethodInfoPtr_get_start_Public_Abstract_Virtual_New_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00012008 File Offset: 0x00010208
		public unsafe virtual double duration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeClipBase.NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00012050 File Offset: 0x00010250
		public unsafe override long intervalStart
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477783, XrefRangeEnd = 477791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeClipBase.NativeMethodInfoPtr_get_intervalStart_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00012098 File Offset: 0x00010298
		public unsafe override long intervalEnd
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477791, XrefRangeEnd = 477799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeClipBase.NativeMethodInfoPtr_get_intervalEnd_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000120E0 File Offset: 0x000102E0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeClipBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeClipBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClipBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000312F File Offset: 0x0000132F
		public RuntimeClipBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_get_start_Public_Abstract_Virtual_New_get_Double_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Double_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_get_intervalStart_Public_Virtual_get_Int64_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_get_intervalEnd_Public_Virtual_get_Int64_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
