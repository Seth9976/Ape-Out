using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000122 RID: 290
	public class MonoAsyncCall : Object
	{
		// Token: 0x060014D4 RID: 5332 RVA: 0x00083878 File Offset: 0x00081A78
		// Note: this type is marked as 'beforefieldinit'.
		static MonoAsyncCall()
		{
			Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoAsyncCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr);
			MonoAsyncCall.NativeFieldInfoPtr_msg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, "msg");
			MonoAsyncCall.NativeFieldInfoPtr_cb_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, "cb_method");
			MonoAsyncCall.NativeFieldInfoPtr_cb_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, "cb_target");
			MonoAsyncCall.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, "state");
			MonoAsyncCall.NativeFieldInfoPtr_res = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, "res");
			MonoAsyncCall.NativeFieldInfoPtr_out_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, "out_args");
			MonoAsyncCall.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, 100666918);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00083934 File Offset: 0x00081B34
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoAsyncCall()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoAsyncCall.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00007223 File Offset: 0x00005423
		public MonoAsyncCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x00083970 File Offset: 0x00081B70
		// (set) Token: 0x060014D8 RID: 5336 RVA: 0x0000722C File Offset: 0x0000542C
		public unsafe Object msg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_msg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_msg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x000839A0 File Offset: 0x00081BA0
		// (set) Token: 0x060014DA RID: 5338 RVA: 0x0000724B File Offset: 0x0000544B
		public unsafe IntPtr cb_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_cb_method);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_cb_method)) = value;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x000839C8 File Offset: 0x00081BC8
		// (set) Token: 0x060014DC RID: 5340 RVA: 0x00007266 File Offset: 0x00005466
		public unsafe Object cb_target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_cb_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_cb_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x000839F8 File Offset: 0x00081BF8
		// (set) Token: 0x060014DE RID: 5342 RVA: 0x00007285 File Offset: 0x00005485
		public unsafe Object state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x00083A28 File Offset: 0x00081C28
		// (set) Token: 0x060014E0 RID: 5344 RVA: 0x000072A4 File Offset: 0x000054A4
		public unsafe Object res
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_res);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_res), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x00083A58 File Offset: 0x00081C58
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x000072C3 File Offset: 0x000054C3
		public unsafe Object out_args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_out_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_out_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeFieldInfoPtr_msg;

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeFieldInfoPtr_cb_method;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeFieldInfoPtr_cb_target;

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeFieldInfoPtr_res;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeFieldInfoPtr_out_args;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
