using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x0200025B RID: 603
	public class CoroutineManager : MonoBehaviour
	{
		// Token: 0x060045F4 RID: 17908 RVA: 0x00105254 File Offset: 0x00103454
		// Note: this type is marked as 'beforefieldinit'.
		static CoroutineManager()
		{
			Il2CppClassPointerStore<CoroutineManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "CoroutineManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoroutineManager>.NativeClassPtr);
			CoroutineManager.NativeFieldInfoPtr_mInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoroutineManager>.NativeClassPtr, "mInstance");
			CoroutineManager.NativeMethodInfoPtr_get_pInstance_Private_Static_get_CoroutineManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager>.NativeClassPtr, 100670359);
			CoroutineManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager>.NativeClassPtr, 100670360);
			CoroutineManager.NativeMethodInfoPtr_Start_Public_Static_Coroutine_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager>.NativeClassPtr, 100670361);
			CoroutineManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager>.NativeClassPtr, 100670362);
		}

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x060045F5 RID: 17909 RVA: 0x001052E8 File Offset: 0x001034E8
		public unsafe static CoroutineManager pInstance
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 114186, RefRangeEnd = 114192, XrefRangeStart = 114153, XrefRangeEnd = 114186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoroutineManager.NativeMethodInfoPtr_get_pInstance_Private_Static_get_CoroutineManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CoroutineManager>(intPtr3) : null;
			}
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x0010531C File Offset: 0x0010351C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114192, XrefRangeEnd = 114201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoroutineManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x00105350 File Offset: 0x00103550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114201, XrefRangeEnd = 114204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coroutine Start(IEnumerator coroutine)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coroutine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoroutineManager.NativeMethodInfoPtr_Start_Public_Static_Coroutine_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x00105394 File Offset: 0x00103594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CoroutineManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoroutineManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoroutineManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x00029BBA File Offset: 0x00027DBA
		public CoroutineManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x060045FA RID: 17914 RVA: 0x001053D0 File Offset: 0x001035D0
		// (set) Token: 0x060045FB RID: 17915 RVA: 0x00029BC3 File Offset: 0x00027DC3
		public unsafe static CoroutineManager mInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoroutineManager.NativeFieldInfoPtr_mInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CoroutineManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoroutineManager.NativeFieldInfoPtr_mInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B6D RID: 11117
		private static readonly IntPtr NativeFieldInfoPtr_mInstance;

		// Token: 0x04002B6E RID: 11118
		private static readonly IntPtr NativeMethodInfoPtr_get_pInstance_Private_Static_get_CoroutineManager_0;

		// Token: 0x04002B6F RID: 11119
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002B70 RID: 11120
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Static_Coroutine_IEnumerator_0;

		// Token: 0x04002B71 RID: 11121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
