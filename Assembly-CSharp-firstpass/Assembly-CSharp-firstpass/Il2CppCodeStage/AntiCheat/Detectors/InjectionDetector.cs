using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppCodeStage.AntiCheat.Detectors
{
	// Token: 0x0200020C RID: 524
	public class InjectionDetector : ActDetectorBase
	{
		// Token: 0x06001CD0 RID: 7376 RVA: 0x00082AFC File Offset: 0x00080CFC
		// Note: this type is marked as 'beforefieldinit'.
		static InjectionDetector()
		{
			Il2CppClassPointerStore<InjectionDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.Detectors", "InjectionDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InjectionDetector>.NativeClassPtr);
			InjectionDetector.NativeFieldInfoPtr_ComponentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjectionDetector>.NativeClassPtr, "ComponentName");
			InjectionDetector.NativeFieldInfoPtr_FinalLogPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjectionDetector>.NativeClassPtr, "FinalLogPrefix");
			InjectionDetector.NativeMethodInfoPtr_get_Instance_Public_Static_get_InjectionDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjectionDetector>.NativeClassPtr, 100668002);
			InjectionDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjectionDetector>.NativeClassPtr, 100668003);
			InjectionDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjectionDetector>.NativeClassPtr, 100668004);
			InjectionDetector.NativeMethodInfoPtr_StopDetection_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjectionDetector>.NativeClassPtr, 100668005);
			InjectionDetector.NativeMethodInfoPtr_Dispose_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjectionDetector>.NativeClassPtr, 100668006);
			InjectionDetector.NativeMethodInfoPtr_StartDetectionAutomatically_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjectionDetector>.NativeClassPtr, 100668007);
			InjectionDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjectionDetector>.NativeClassPtr, 100668008);
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001CD1 RID: 7377 RVA: 0x00082BE0 File Offset: 0x00080DE0
		public unsafe static InjectionDetector Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27890, XrefRangeEnd = 27896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InjectionDetector.NativeMethodInfoPtr_get_Instance_Public_Static_get_InjectionDetector_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InjectionDetector>(intPtr3) : null;
			}
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x00082C14 File Offset: 0x00080E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27896, XrefRangeEnd = 27902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartDetection()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InjectionDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x00082C3C File Offset: 0x00080E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27902, XrefRangeEnd = 27908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartDetection(Action<string> callback)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InjectionDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x00082C74 File Offset: 0x00080E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27908, XrefRangeEnd = 27914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopDetection()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InjectionDetector.NativeMethodInfoPtr_StopDetection_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x00082C9C File Offset: 0x00080E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27914, XrefRangeEnd = 27920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InjectionDetector.NativeMethodInfoPtr_Dispose_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x00082CC4 File Offset: 0x00080EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27920, XrefRangeEnd = 27926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartDetectionAutomatically()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InjectionDetector.NativeMethodInfoPtr_StartDetectionAutomatically_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x00082D00 File Offset: 0x00080F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InjectionDetector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InjectionDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InjectionDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x0000A51B File Offset: 0x0000871B
		public InjectionDetector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x00082D3C File Offset: 0x00080F3C
		// (set) Token: 0x06001CDA RID: 7386 RVA: 0x0000A524 File Offset: 0x00008724
		public unsafe static string ComponentName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InjectionDetector.NativeFieldInfoPtr_ComponentName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InjectionDetector.NativeFieldInfoPtr_ComponentName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x00082D5C File Offset: 0x00080F5C
		// (set) Token: 0x06001CDC RID: 7388 RVA: 0x0000A536 File Offset: 0x00008736
		public unsafe static string FinalLogPrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InjectionDetector.NativeFieldInfoPtr_FinalLogPrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InjectionDetector.NativeFieldInfoPtr_FinalLogPrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001E03 RID: 7683
		private static readonly IntPtr NativeFieldInfoPtr_ComponentName;

		// Token: 0x04001E04 RID: 7684
		private static readonly IntPtr NativeFieldInfoPtr_FinalLogPrefix;

		// Token: 0x04001E05 RID: 7685
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_InjectionDetector_0;

		// Token: 0x04001E06 RID: 7686
		private static readonly IntPtr NativeMethodInfoPtr_StartDetection_Public_Static_Void_0;

		// Token: 0x04001E07 RID: 7687
		private static readonly IntPtr NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_1_String_0;

		// Token: 0x04001E08 RID: 7688
		private static readonly IntPtr NativeMethodInfoPtr_StopDetection_Public_Static_Void_0;

		// Token: 0x04001E09 RID: 7689
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Static_Void_0;

		// Token: 0x04001E0A RID: 7690
		private static readonly IntPtr NativeMethodInfoPtr_StartDetectionAutomatically_Protected_Virtual_Void_0;

		// Token: 0x04001E0B RID: 7691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
