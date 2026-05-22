using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001D3 RID: 467
	public class WaterParallaxer : MonoBehaviour
	{
		// Token: 0x060032AC RID: 12972 RVA: 0x000BF710 File Offset: 0x000BD910
		// Note: this type is marked as 'beforefieldinit'.
		static WaterParallaxer()
		{
			Il2CppClassPointerStore<WaterParallaxer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WaterParallaxer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterParallaxer>.NativeClassPtr);
			WaterParallaxer.NativeFieldInfoPtr_defPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterParallaxer>.NativeClassPtr, "defPos");
			WaterParallaxer.NativeFieldInfoPtr_startFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterParallaxer>.NativeClassPtr, "startFlag");
			WaterParallaxer.NativeFieldInfoPtr_dontSetScreenDefPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterParallaxer>.NativeClassPtr, "dontSetScreenDefPos");
			WaterParallaxer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterParallaxer>.NativeClassPtr, 100667237);
			WaterParallaxer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterParallaxer>.NativeClassPtr, 100667238);
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x000BF7A4 File Offset: 0x000BD9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85951, XrefRangeEnd = 85977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterParallaxer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x000BF7D8 File Offset: 0x000BD9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterParallaxer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterParallaxer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterParallaxer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x00022B56 File Offset: 0x00020D56
		public WaterParallaxer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x060032B0 RID: 12976 RVA: 0x000BF814 File Offset: 0x000BDA14
		// (set) Token: 0x060032B1 RID: 12977 RVA: 0x00022B5F File Offset: 0x00020D5F
		public unsafe Vector2 defPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterParallaxer.NativeFieldInfoPtr_defPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterParallaxer.NativeFieldInfoPtr_defPos)) = value;
			}
		}

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x060032B2 RID: 12978 RVA: 0x000BF83C File Offset: 0x000BDA3C
		// (set) Token: 0x060032B3 RID: 12979 RVA: 0x00022B7A File Offset: 0x00020D7A
		public unsafe bool startFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterParallaxer.NativeFieldInfoPtr_startFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterParallaxer.NativeFieldInfoPtr_startFlag)) = value;
			}
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x060032B4 RID: 12980 RVA: 0x000BF864 File Offset: 0x000BDA64
		// (set) Token: 0x060032B5 RID: 12981 RVA: 0x00022B95 File Offset: 0x00020D95
		public unsafe bool dontSetScreenDefPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterParallaxer.NativeFieldInfoPtr_dontSetScreenDefPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterParallaxer.NativeFieldInfoPtr_dontSetScreenDefPos)) = value;
			}
		}

		// Token: 0x04001DA6 RID: 7590
		private static readonly IntPtr NativeFieldInfoPtr_defPos;

		// Token: 0x04001DA7 RID: 7591
		private static readonly IntPtr NativeFieldInfoPtr_startFlag;

		// Token: 0x04001DA8 RID: 7592
		private static readonly IntPtr NativeFieldInfoPtr_dontSetScreenDefPos;

		// Token: 0x04001DA9 RID: 7593
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001DAA RID: 7594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
