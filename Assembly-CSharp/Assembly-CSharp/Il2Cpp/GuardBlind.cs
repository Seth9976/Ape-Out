using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000ED RID: 237
	public class GuardBlind : GuardMode
	{
		// Token: 0x06001C4A RID: 7242 RVA: 0x00083C84 File Offset: 0x00081E84
		// Note: this type is marked as 'beforefieldinit'.
		static GuardBlind()
		{
			Il2CppClassPointerStore<GuardBlind>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardBlind");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardBlind>.NativeClassPtr);
			GuardBlind.NativeFieldInfoPtr_aimRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardBlind>.NativeClassPtr, "aimRight");
			GuardBlind.NativeFieldInfoPtr_waggleTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardBlind>.NativeClassPtr, "waggleTimer");
			GuardBlind.NativeFieldInfoPtr_aimPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardBlind>.NativeClassPtr, "aimPos");
			GuardBlind.NativeFieldInfoPtr_desRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardBlind>.NativeClassPtr, "desRot");
			GuardBlind.NativeFieldInfoPtr_backSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardBlind>.NativeClassPtr, "backSpd");
			GuardBlind.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardBlind>.NativeClassPtr, 100665599);
			GuardBlind.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardBlind>.NativeClassPtr, 100665600);
			GuardBlind.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardBlind>.NativeClassPtr, 100665601);
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x00083D54 File Offset: 0x00081F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62856, XrefRangeEnd = 62858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardBlind(GuardState st)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardBlind>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardBlind.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x00083DA0 File Offset: 0x00081FA0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardBlind.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x00083DDC File Offset: 0x00081FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62858, XrefRangeEnd = 62892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardBlind.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x00013F6E File Offset: 0x0001216E
		public GuardBlind(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x00083E18 File Offset: 0x00082018
		// (set) Token: 0x06001C50 RID: 7248 RVA: 0x00013F77 File Offset: 0x00012177
		public unsafe bool aimRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBlind.NativeFieldInfoPtr_aimRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBlind.NativeFieldInfoPtr_aimRight)) = value;
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x00083E40 File Offset: 0x00082040
		// (set) Token: 0x06001C52 RID: 7250 RVA: 0x00013F92 File Offset: 0x00012192
		public unsafe int waggleTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBlind.NativeFieldInfoPtr_waggleTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBlind.NativeFieldInfoPtr_waggleTimer)) = value;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x00083E68 File Offset: 0x00082068
		// (set) Token: 0x06001C54 RID: 7252 RVA: 0x00013FAD File Offset: 0x000121AD
		public unsafe Vector2 aimPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBlind.NativeFieldInfoPtr_aimPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBlind.NativeFieldInfoPtr_aimPos)) = value;
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x00083E90 File Offset: 0x00082090
		// (set) Token: 0x06001C56 RID: 7254 RVA: 0x00013FC8 File Offset: 0x000121C8
		public unsafe float desRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBlind.NativeFieldInfoPtr_desRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBlind.NativeFieldInfoPtr_desRot)) = value;
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x00083EB8 File Offset: 0x000820B8
		// (set) Token: 0x06001C58 RID: 7256 RVA: 0x00013FE3 File Offset: 0x000121E3
		public unsafe float backSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBlind.NativeFieldInfoPtr_backSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBlind.NativeFieldInfoPtr_backSpd)) = value;
			}
		}

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeFieldInfoPtr_aimRight;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeFieldInfoPtr_waggleTimer;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeFieldInfoPtr_aimPos;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeFieldInfoPtr_desRot;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeFieldInfoPtr_backSpd;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_0;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
	}
}
