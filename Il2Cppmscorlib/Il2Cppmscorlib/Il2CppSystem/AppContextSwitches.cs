using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200005F RID: 95
	public static class AppContextSwitches : Object
	{
		// Token: 0x06000654 RID: 1620 RVA: 0x0003F60C File Offset: 0x0003D80C
		// Note: this type is marked as 'beforefieldinit'.
		static AppContextSwitches()
		{
			Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AppContextSwitches");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr);
			AppContextSwitches.NativeFieldInfoPtr_ThrowExceptionIfDisposedCancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr, "ThrowExceptionIfDisposedCancellationTokenSource");
			AppContextSwitches.NativeFieldInfoPtr_SetActorAsReferenceWhenCopyingClaimsIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr, "SetActorAsReferenceWhenCopyingClaimsIdentity");
			AppContextSwitches.NativeFieldInfoPtr_NoAsyncCurrentCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr, "NoAsyncCurrentCulture");
			AppContextSwitches.NativeFieldInfoPtr_PreserveEventListnerObjectIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr, "PreserveEventListnerObjectIdentity");
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0000400A File Offset: 0x0000220A
		public AppContextSwitches(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0003F68C File Offset: 0x0003D88C
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00004013 File Offset: 0x00002213
		public unsafe static bool ThrowExceptionIfDisposedCancellationTokenSource
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(AppContextSwitches.NativeFieldInfoPtr_ThrowExceptionIfDisposedCancellationTokenSource, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppContextSwitches.NativeFieldInfoPtr_ThrowExceptionIfDisposedCancellationTokenSource, (void*)(&value));
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0003F6A8 File Offset: 0x0003D8A8
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x00004021 File Offset: 0x00002221
		public unsafe static bool SetActorAsReferenceWhenCopyingClaimsIdentity
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(AppContextSwitches.NativeFieldInfoPtr_SetActorAsReferenceWhenCopyingClaimsIdentity, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppContextSwitches.NativeFieldInfoPtr_SetActorAsReferenceWhenCopyingClaimsIdentity, (void*)(&value));
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x0003F6C4 File Offset: 0x0003D8C4
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x0000402F File Offset: 0x0000222F
		public unsafe static bool NoAsyncCurrentCulture
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(AppContextSwitches.NativeFieldInfoPtr_NoAsyncCurrentCulture, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppContextSwitches.NativeFieldInfoPtr_NoAsyncCurrentCulture, (void*)(&value));
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x0003F6E0 File Offset: 0x0003D8E0
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x0000403D File Offset: 0x0000223D
		public unsafe static bool PreserveEventListnerObjectIdentity
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(AppContextSwitches.NativeFieldInfoPtr_PreserveEventListnerObjectIdentity, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppContextSwitches.NativeFieldInfoPtr_PreserveEventListnerObjectIdentity, (void*)(&value));
			}
		}

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeFieldInfoPtr_ThrowExceptionIfDisposedCancellationTokenSource;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeFieldInfoPtr_SetActorAsReferenceWhenCopyingClaimsIdentity;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeFieldInfoPtr_NoAsyncCurrentCulture;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeFieldInfoPtr_PreserveEventListnerObjectIdentity;
	}
}
