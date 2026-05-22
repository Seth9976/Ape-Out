using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000017 RID: 23
	public static class AsyncHelper : Object
	{
		// Token: 0x06000153 RID: 339 RVA: 0x00018C48 File Offset: 0x00016E48
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncHelper()
		{
			Il2CppClassPointerStore<AsyncHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "AsyncHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncHelper>.NativeClassPtr);
			AsyncHelper.NativeFieldInfoPtr_DoneTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncHelper>.NativeClassPtr, "DoneTask");
			AsyncHelper.NativeFieldInfoPtr_DoneTaskTrue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncHelper>.NativeClassPtr, "DoneTaskTrue");
			AsyncHelper.NativeFieldInfoPtr_DoneTaskFalse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncHelper>.NativeClassPtr, "DoneTaskFalse");
			AsyncHelper.NativeFieldInfoPtr_DoneTaskZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncHelper>.NativeClassPtr, "DoneTaskZero");
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000297B File Offset: 0x00000B7B
		public AsyncHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00018CC8 File Offset: 0x00016EC8
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00002984 File Offset: 0x00000B84
		public unsafe static Task DoneTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncHelper.NativeFieldInfoPtr_DoneTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncHelper.NativeFieldInfoPtr_DoneTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00018CF0 File Offset: 0x00016EF0
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00002996 File Offset: 0x00000B96
		public unsafe static Task<bool> DoneTaskTrue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncHelper.NativeFieldInfoPtr_DoneTaskTrue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncHelper.NativeFieldInfoPtr_DoneTaskTrue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00018D18 File Offset: 0x00016F18
		// (set) Token: 0x0600015A RID: 346 RVA: 0x000029A8 File Offset: 0x00000BA8
		public unsafe static Task<bool> DoneTaskFalse
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncHelper.NativeFieldInfoPtr_DoneTaskFalse, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncHelper.NativeFieldInfoPtr_DoneTaskFalse, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00018D40 File Offset: 0x00016F40
		// (set) Token: 0x0600015C RID: 348 RVA: 0x000029BA File Offset: 0x00000BBA
		public unsafe static Task<int> DoneTaskZero
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncHelper.NativeFieldInfoPtr_DoneTaskZero, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncHelper.NativeFieldInfoPtr_DoneTaskZero, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_DoneTask;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_DoneTaskTrue;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_DoneTaskFalse;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_DoneTaskZero;
	}
}
