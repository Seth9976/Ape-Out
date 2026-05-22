using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000070 RID: 112
	public class BagHolder : MonoBehaviour
	{
		// Token: 0x06000E98 RID: 3736 RVA: 0x0005F1B0 File Offset: 0x0005D3B0
		// Note: this type is marked as 'beforefieldinit'.
		static BagHolder()
		{
			Il2CppClassPointerStore<BagHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BagHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BagHolder>.NativeClassPtr);
			BagHolder.NativeFieldInfoPtr_soundMan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagHolder>.NativeClassPtr, "soundMan");
			BagHolder.NativeFieldInfoPtr_musicSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagHolder>.NativeClassPtr, "musicSystem");
			BagHolder.NativeFieldInfoPtr_tileBags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagHolder>.NativeClassPtr, "tileBags");
			BagHolder.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagHolder>.NativeClassPtr, "me");
			BagHolder.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagHolder>.NativeClassPtr, 100664550);
			BagHolder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagHolder>.NativeClassPtr, 100664551);
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x0005F258 File Offset: 0x0005D458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45575, XrefRangeEnd = 45588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagHolder.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0005F28C File Offset: 0x0005D48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BagHolder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BagHolder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BagHolder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0000AFDC File Offset: 0x000091DC
		public BagHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x0005F2C8 File Offset: 0x0005D4C8
		// (set) Token: 0x06000E9D RID: 3741 RVA: 0x0000AFE5 File Offset: 0x000091E5
		public unsafe GameObject soundMan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagHolder.NativeFieldInfoPtr_soundMan);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagHolder.NativeFieldInfoPtr_soundMan), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x0005F2F8 File Offset: 0x0005D4F8
		// (set) Token: 0x06000E9F RID: 3743 RVA: 0x0000B004 File Offset: 0x00009204
		public unsafe GameObject musicSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagHolder.NativeFieldInfoPtr_musicSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagHolder.NativeFieldInfoPtr_musicSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x0005F328 File Offset: 0x0005D528
		// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x0000B023 File Offset: 0x00009223
		public unsafe Il2CppReferenceArray<TileBags> tileBags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagHolder.NativeFieldInfoPtr_tileBags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TileBags>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BagHolder.NativeFieldInfoPtr_tileBags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x0005F358 File Offset: 0x0005D558
		// (set) Token: 0x06000EA3 RID: 3747 RVA: 0x0000B042 File Offset: 0x00009242
		public unsafe static BagHolder me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BagHolder.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BagHolder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BagHolder.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr_soundMan;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeFieldInfoPtr_musicSystem;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeFieldInfoPtr_tileBags;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
