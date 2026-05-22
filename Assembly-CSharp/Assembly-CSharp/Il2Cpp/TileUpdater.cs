using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001C6 RID: 454
	public class TileUpdater : MonoBehaviour
	{
		// Token: 0x06003226 RID: 12838 RVA: 0x000BE09C File Offset: 0x000BC29C
		// Note: this type is marked as 'beforefieldinit'.
		static TileUpdater()
		{
			Il2CppClassPointerStore<TileUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TileUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileUpdater>.NativeClassPtr);
			TileUpdater.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileUpdater>.NativeClassPtr, "tile");
			TileUpdater.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileUpdater>.NativeClassPtr, "path");
			TileUpdater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUpdater>.NativeClassPtr, 100667189);
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x000BE108 File Offset: 0x000BC308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TileUpdater()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileUpdater>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileUpdater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x000226D5 File Offset: 0x000208D5
		public TileUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x06003229 RID: 12841 RVA: 0x000BE144 File Offset: 0x000BC344
		// (set) Token: 0x0600322A RID: 12842 RVA: 0x000226DE File Offset: 0x000208DE
		public unsafe GameObject tile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileUpdater.NativeFieldInfoPtr_tile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileUpdater.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x0600322B RID: 12843 RVA: 0x000BE174 File Offset: 0x000BC374
		// (set) Token: 0x0600322C RID: 12844 RVA: 0x000226FD File Offset: 0x000208FD
		public unsafe string path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileUpdater.NativeFieldInfoPtr_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileUpdater.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001D5E RID: 7518
		private static readonly IntPtr NativeFieldInfoPtr_tile;

		// Token: 0x04001D5F RID: 7519
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x04001D60 RID: 7520
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
