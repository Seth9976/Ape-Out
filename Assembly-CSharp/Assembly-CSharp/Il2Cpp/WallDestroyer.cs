using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001D1 RID: 465
	public class WallDestroyer : MonoBehaviour
	{
		// Token: 0x06003293 RID: 12947 RVA: 0x000BF350 File Offset: 0x000BD550
		// Note: this type is marked as 'beforefieldinit'.
		static WallDestroyer()
		{
			Il2CppClassPointerStore<WallDestroyer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WallDestroyer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallDestroyer>.NativeClassPtr);
			WallDestroyer.NativeFieldInfoPtr_tim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallDestroyer>.NativeClassPtr, "tim");
			WallDestroyer.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallDestroyer>.NativeClassPtr, 100667232);
			WallDestroyer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallDestroyer>.NativeClassPtr, 100667233);
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x000BF3BC File Offset: 0x000BD5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85890, XrefRangeEnd = 85896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallDestroyer.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x000BF3F0 File Offset: 0x000BD5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WallDestroyer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WallDestroyer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WallDestroyer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x00022A68 File Offset: 0x00020C68
		public WallDestroyer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x06003297 RID: 12951 RVA: 0x000BF42C File Offset: 0x000BD62C
		// (set) Token: 0x06003298 RID: 12952 RVA: 0x00022A71 File Offset: 0x00020C71
		public unsafe int tim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallDestroyer.NativeFieldInfoPtr_tim);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WallDestroyer.NativeFieldInfoPtr_tim)) = value;
			}
		}

		// Token: 0x04001D99 RID: 7577
		private static readonly IntPtr NativeFieldInfoPtr_tim;

		// Token: 0x04001D9A RID: 7578
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001D9B RID: 7579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
