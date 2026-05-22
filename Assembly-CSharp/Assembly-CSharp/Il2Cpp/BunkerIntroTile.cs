using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000096 RID: 150
	public class BunkerIntroTile : MonoBehaviour
	{
		// Token: 0x06001214 RID: 4628 RVA: 0x00068234 File Offset: 0x00066434
		// Note: this type is marked as 'beforefieldinit'.
		static BunkerIntroTile()
		{
			Il2CppClassPointerStore<BunkerIntroTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BunkerIntroTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BunkerIntroTile>.NativeClassPtr);
			BunkerIntroTile.NativeFieldInfoPtr_customPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntroTile>.NativeClassPtr, "customPath");
			BunkerIntroTile.NativeFieldInfoPtr_squad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntroTile>.NativeClassPtr, "squad");
			BunkerIntroTile.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerIntroTile>.NativeClassPtr, "me");
			BunkerIntroTile.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntroTile>.NativeClassPtr, 100664820);
			BunkerIntroTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerIntroTile>.NativeClassPtr, 100664821);
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x000682C8 File Offset: 0x000664C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49627, XrefRangeEnd = 49629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntroTile.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x000682FC File Offset: 0x000664FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BunkerIntroTile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BunkerIntroTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerIntroTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x0000D455 File Offset: 0x0000B655
		public BunkerIntroTile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x00068338 File Offset: 0x00066538
		// (set) Token: 0x06001219 RID: 4633 RVA: 0x0000D45E File Offset: 0x0000B65E
		public unsafe Il2CppReferenceArray<Transform> customPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntroTile.NativeFieldInfoPtr_customPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntroTile.NativeFieldInfoPtr_customPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x00068368 File Offset: 0x00066568
		// (set) Token: 0x0600121B RID: 4635 RVA: 0x0000D47D File Offset: 0x0000B67D
		public unsafe SquadManager squad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntroTile.NativeFieldInfoPtr_squad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SquadManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerIntroTile.NativeFieldInfoPtr_squad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x00068398 File Offset: 0x00066598
		// (set) Token: 0x0600121D RID: 4637 RVA: 0x0000D49C File Offset: 0x0000B69C
		public unsafe static BunkerIntroTile me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BunkerIntroTile.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BunkerIntroTile>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BunkerIntroTile.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeFieldInfoPtr_customPath;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeFieldInfoPtr_squad;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
