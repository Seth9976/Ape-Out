using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000174 RID: 372
	public class Roofwire : MonoBehaviour
	{
		// Token: 0x06002CD1 RID: 11473 RVA: 0x000AFD70 File Offset: 0x000ADF70
		// Note: this type is marked as 'beforefieldinit'.
		static Roofwire()
		{
			Il2CppClassPointerStore<Roofwire>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Roofwire");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Roofwire>.NativeClassPtr);
			Roofwire.NativeFieldInfoPtr_v1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Roofwire>.NativeClassPtr, "v1");
			Roofwire.NativeFieldInfoPtr_v2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Roofwire>.NativeClassPtr, "v2");
			Roofwire.NativeFieldInfoPtr_myRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Roofwire>.NativeClassPtr, "myRend");
			Roofwire.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roofwire>.NativeClassPtr, 100666781);
			Roofwire.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roofwire>.NativeClassPtr, 100666782);
			Roofwire.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roofwire>.NativeClassPtr, 100666783);
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x000AFE18 File Offset: 0x000AE018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80779, XrefRangeEnd = 80782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roofwire.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x000AFE4C File Offset: 0x000AE04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80782, XrefRangeEnd = 80790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roofwire.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x000AFE80 File Offset: 0x000AE080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Roofwire()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Roofwire>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roofwire.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x0001F18C File Offset: 0x0001D38C
		public Roofwire(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06002CD6 RID: 11478 RVA: 0x000AFEBC File Offset: 0x000AE0BC
		// (set) Token: 0x06002CD7 RID: 11479 RVA: 0x0001F195 File Offset: 0x0001D395
		public unsafe Transform v1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Roofwire.NativeFieldInfoPtr_v1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Roofwire.NativeFieldInfoPtr_v1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06002CD8 RID: 11480 RVA: 0x000AFEEC File Offset: 0x000AE0EC
		// (set) Token: 0x06002CD9 RID: 11481 RVA: 0x0001F1B4 File Offset: 0x0001D3B4
		public unsafe Transform v2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Roofwire.NativeFieldInfoPtr_v2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Roofwire.NativeFieldInfoPtr_v2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06002CDA RID: 11482 RVA: 0x000AFF1C File Offset: 0x000AE11C
		// (set) Token: 0x06002CDB RID: 11483 RVA: 0x0001F1D3 File Offset: 0x0001D3D3
		public unsafe LineRenderer myRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Roofwire.NativeFieldInfoPtr_myRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Roofwire.NativeFieldInfoPtr_myRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A63 RID: 6755
		private static readonly IntPtr NativeFieldInfoPtr_v1;

		// Token: 0x04001A64 RID: 6756
		private static readonly IntPtr NativeFieldInfoPtr_v2;

		// Token: 0x04001A65 RID: 6757
		private static readonly IntPtr NativeFieldInfoPtr_myRend;

		// Token: 0x04001A66 RID: 6758
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001A67 RID: 6759
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001A68 RID: 6760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
