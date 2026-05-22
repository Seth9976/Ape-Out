using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Platforms.PS4.Internal
{
	// Token: 0x0200017E RID: 382
	public class LoggedInUser : Object
	{
		// Token: 0x06002891 RID: 10385 RVA: 0x000CD5C8 File Offset: 0x000CB7C8
		// Note: this type is marked as 'beforefieldinit'.
		static LoggedInUser()
		{
			Il2CppClassPointerStore<LoggedInUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.PS4.Internal", "LoggedInUser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoggedInUser>.NativeClassPtr);
			LoggedInUser.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggedInUser>.NativeClassPtr, "status");
			LoggedInUser.NativeFieldInfoPtr_primaryUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggedInUser>.NativeClassPtr, "primaryUser");
			LoggedInUser.NativeFieldInfoPtr_userId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggedInUser>.NativeClassPtr, "userId");
			LoggedInUser.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggedInUser>.NativeClassPtr, "color");
			LoggedInUser.NativeFieldInfoPtr_userName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggedInUser>.NativeClassPtr, "userName");
			LoggedInUser.NativeFieldInfoPtr_padHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggedInUser>.NativeClassPtr, "padHandle");
			LoggedInUser.NativeFieldInfoPtr_move0Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggedInUser>.NativeClassPtr, "move0Handle");
			LoggedInUser.NativeFieldInfoPtr_move1Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggedInUser>.NativeClassPtr, "move1Handle");
			LoggedInUser.NativeFieldInfoPtr_aimHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggedInUser>.NativeClassPtr, "aimHandle");
			LoggedInUser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggedInUser>.NativeClassPtr, 100673185);
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x000CD6C0 File Offset: 0x000CB8C0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoggedInUser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoggedInUser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggedInUser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x0000F934 File Offset: 0x0000DB34
		public LoggedInUser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x000CD6FC File Offset: 0x000CB8FC
		// (set) Token: 0x06002895 RID: 10389 RVA: 0x0000F93D File Offset: 0x0000DB3D
		public unsafe int status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUser.NativeFieldInfoPtr_status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUser.NativeFieldInfoPtr_status)) = value;
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x000CD724 File Offset: 0x000CB924
		// (set) Token: 0x06002897 RID: 10391 RVA: 0x0000F958 File Offset: 0x0000DB58
		public unsafe bool primaryUser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUser.NativeFieldInfoPtr_primaryUser);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUser.NativeFieldInfoPtr_primaryUser)) = value;
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06002898 RID: 10392 RVA: 0x000CD74C File Offset: 0x000CB94C
		// (set) Token: 0x06002899 RID: 10393 RVA: 0x0000F973 File Offset: 0x0000DB73
		public unsafe int userId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUser.NativeFieldInfoPtr_userId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUser.NativeFieldInfoPtr_userId)) = value;
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x0600289A RID: 10394 RVA: 0x000CD774 File Offset: 0x000CB974
		// (set) Token: 0x0600289B RID: 10395 RVA: 0x0000F98E File Offset: 0x0000DB8E
		public unsafe int color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUser.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUser.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x0600289C RID: 10396 RVA: 0x000CD79C File Offset: 0x000CB99C
		// (set) Token: 0x0600289D RID: 10397 RVA: 0x0000F9A9 File Offset: 0x0000DBA9
		public unsafe string userName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUser.NativeFieldInfoPtr_userName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUser.NativeFieldInfoPtr_userName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x000CD7C4 File Offset: 0x000CB9C4
		// (set) Token: 0x0600289F RID: 10399 RVA: 0x0000F9C8 File Offset: 0x0000DBC8
		public unsafe int padHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUser.NativeFieldInfoPtr_padHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUser.NativeFieldInfoPtr_padHandle)) = value;
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x000CD7EC File Offset: 0x000CB9EC
		// (set) Token: 0x060028A1 RID: 10401 RVA: 0x0000F9E3 File Offset: 0x0000DBE3
		public unsafe int move0Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUser.NativeFieldInfoPtr_move0Handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUser.NativeFieldInfoPtr_move0Handle)) = value;
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x000CD814 File Offset: 0x000CBA14
		// (set) Token: 0x060028A3 RID: 10403 RVA: 0x0000F9FE File Offset: 0x0000DBFE
		public unsafe int move1Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUser.NativeFieldInfoPtr_move1Handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUser.NativeFieldInfoPtr_move1Handle)) = value;
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x000CD83C File Offset: 0x000CBA3C
		// (set) Token: 0x060028A5 RID: 10405 RVA: 0x0000FA19 File Offset: 0x0000DC19
		public unsafe int aimHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUser.NativeFieldInfoPtr_aimHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUser.NativeFieldInfoPtr_aimHandle)) = value;
			}
		}

		// Token: 0x04002250 RID: 8784
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x04002251 RID: 8785
		private static readonly IntPtr NativeFieldInfoPtr_primaryUser;

		// Token: 0x04002252 RID: 8786
		private static readonly IntPtr NativeFieldInfoPtr_userId;

		// Token: 0x04002253 RID: 8787
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04002254 RID: 8788
		private static readonly IntPtr NativeFieldInfoPtr_userName;

		// Token: 0x04002255 RID: 8789
		private static readonly IntPtr NativeFieldInfoPtr_padHandle;

		// Token: 0x04002256 RID: 8790
		private static readonly IntPtr NativeFieldInfoPtr_move0Handle;

		// Token: 0x04002257 RID: 8791
		private static readonly IntPtr NativeFieldInfoPtr_move1Handle;

		// Token: 0x04002258 RID: 8792
		private static readonly IntPtr NativeFieldInfoPtr_aimHandle;

		// Token: 0x04002259 RID: 8793
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
