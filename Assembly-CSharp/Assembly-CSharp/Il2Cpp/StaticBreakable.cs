using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001AA RID: 426
	public class StaticBreakable : MessageReceiver
	{
		// Token: 0x060030A1 RID: 12449 RVA: 0x000BA1C8 File Offset: 0x000B83C8
		// Note: this type is marked as 'beforefieldinit'.
		static StaticBreakable()
		{
			Il2CppClassPointerStore<StaticBreakable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StaticBreakable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticBreakable>.NativeClassPtr);
			StaticBreakable.NativeFieldInfoPtr_breaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticBreakable>.NativeClassPtr, "breaking");
			StaticBreakable.NativeFieldInfoPtr_delaypt28 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticBreakable>.NativeClassPtr, "delaypt28");
			StaticBreakable.NativeMethodInfoPtr_Break_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBreakable>.NativeClassPtr, 100667096);
			StaticBreakable.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBreakable>.NativeClassPtr, 100667097);
			StaticBreakable.NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBreakable>.NativeClassPtr, 100667098);
			StaticBreakable.NativeMethodInfoPtr_OnSmashed_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBreakable>.NativeClassPtr, 100667099);
			StaticBreakable.NativeMethodInfoPtr_OnSlammed_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBreakable>.NativeClassPtr, 100667100);
			StaticBreakable.NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBreakable>.NativeClassPtr, 100667101);
			StaticBreakable.NativeMethodInfoPtr_OnMidPush_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBreakable>.NativeClassPtr, 100667102);
			StaticBreakable.NativeMethodInfoPtr_OnFire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBreakable>.NativeClassPtr, 100667103);
			StaticBreakable.NativeMethodInfoPtr_DelayBreak_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBreakable>.NativeClassPtr, 100667104);
			StaticBreakable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBreakable>.NativeClassPtr, 100667105);
		}

		// Token: 0x060030A2 RID: 12450 RVA: 0x000BA2E8 File Offset: 0x000B84E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Break()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticBreakable.NativeMethodInfoPtr_Break_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030A3 RID: 12451 RVA: 0x000BA324 File Offset: 0x000B8524
		[CallerCount(0)]
		public unsafe override void OnBlown(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticBreakable.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030A4 RID: 12452 RVA: 0x000BA370 File Offset: 0x000B8570
		[CallerCount(0)]
		public unsafe override void OnShot(Il2CppStructArray<Vector2> pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticBreakable.NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030A5 RID: 12453 RVA: 0x000BA3C0 File Offset: 0x000B85C0
		[CallerCount(0)]
		public unsafe override void OnSmashed(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticBreakable.NativeMethodInfoPtr_OnSmashed_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x000BA40C File Offset: 0x000B860C
		[CallerCount(0)]
		public unsafe override void OnSlammed(Il2CppStructArray<Vector2> pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticBreakable.NativeMethodInfoPtr_OnSlammed_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030A7 RID: 12455 RVA: 0x000BA45C File Offset: 0x000B865C
		[CallerCount(0)]
		public unsafe override void OnPushed(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticBreakable.NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x000BA4A8 File Offset: 0x000B86A8
		[CallerCount(0)]
		public unsafe override void OnMidPush(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticBreakable.NativeMethodInfoPtr_OnMidPush_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x000BA4F4 File Offset: 0x000B86F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84560, XrefRangeEnd = 84564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnFire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticBreakable.NativeMethodInfoPtr_OnFire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x000BA530 File Offset: 0x000B8730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84564, XrefRangeEnd = 84567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayBreak()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticBreakable.NativeMethodInfoPtr_DelayBreak_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x000BA570 File Offset: 0x000B8770
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84576, RefRangeEnd = 84579, XrefRangeStart = 84567, XrefRangeEnd = 84576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StaticBreakable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticBreakable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticBreakable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x00021703 File Offset: 0x0001F903
		public StaticBreakable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x060030AD RID: 12461 RVA: 0x000BA5AC File Offset: 0x000B87AC
		// (set) Token: 0x060030AE RID: 12462 RVA: 0x0002170C File Offset: 0x0001F90C
		public unsafe bool breaking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticBreakable.NativeFieldInfoPtr_breaking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticBreakable.NativeFieldInfoPtr_breaking)) = value;
			}
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x060030AF RID: 12463 RVA: 0x000BA5D4 File Offset: 0x000B87D4
		// (set) Token: 0x060030B0 RID: 12464 RVA: 0x00021727 File Offset: 0x0001F927
		public unsafe WaitForSeconds delaypt28
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticBreakable.NativeFieldInfoPtr_delaypt28);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticBreakable.NativeFieldInfoPtr_delaypt28), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C8C RID: 7308
		private static readonly IntPtr NativeFieldInfoPtr_breaking;

		// Token: 0x04001C8D RID: 7309
		private static readonly IntPtr NativeFieldInfoPtr_delaypt28;

		// Token: 0x04001C8E RID: 7310
		private static readonly IntPtr NativeMethodInfoPtr_Break_Public_Virtual_New_Void_0;

		// Token: 0x04001C8F RID: 7311
		private static readonly IntPtr NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001C90 RID: 7312
		private static readonly IntPtr NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04001C91 RID: 7313
		private static readonly IntPtr NativeMethodInfoPtr_OnSmashed_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001C92 RID: 7314
		private static readonly IntPtr NativeMethodInfoPtr_OnSlammed_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04001C93 RID: 7315
		private static readonly IntPtr NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001C94 RID: 7316
		private static readonly IntPtr NativeMethodInfoPtr_OnMidPush_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001C95 RID: 7317
		private static readonly IntPtr NativeMethodInfoPtr_OnFire_Public_Virtual_Void_0;

		// Token: 0x04001C96 RID: 7318
		private static readonly IntPtr NativeMethodInfoPtr_DelayBreak_Public_IEnumerator_0;

		// Token: 0x04001C97 RID: 7319
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000352 RID: 850
		[ObfuscatedName("StaticBreakable+<DelayBreak>d__10")]
		public sealed class _DelayBreak_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x06005392 RID: 21394 RVA: 0x0012F06C File Offset: 0x0012D26C
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayBreak_d__10()
			{
				Il2CppClassPointerStore<StaticBreakable._DelayBreak_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StaticBreakable>.NativeClassPtr, "<DelayBreak>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticBreakable._DelayBreak_d__10>.NativeClassPtr);
				StaticBreakable._DelayBreak_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticBreakable._DelayBreak_d__10>.NativeClassPtr, "<>1__state");
				StaticBreakable._DelayBreak_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticBreakable._DelayBreak_d__10>.NativeClassPtr, "<>2__current");
				StaticBreakable._DelayBreak_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticBreakable._DelayBreak_d__10>.NativeClassPtr, "<>4__this");
				StaticBreakable._DelayBreak_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBreakable._DelayBreak_d__10>.NativeClassPtr, 100667106);
				StaticBreakable._DelayBreak_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBreakable._DelayBreak_d__10>.NativeClassPtr, 100667107);
				StaticBreakable._DelayBreak_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBreakable._DelayBreak_d__10>.NativeClassPtr, 100667108);
				StaticBreakable._DelayBreak_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBreakable._DelayBreak_d__10>.NativeClassPtr, 100667109);
				StaticBreakable._DelayBreak_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBreakable._DelayBreak_d__10>.NativeClassPtr, 100667110);
				StaticBreakable._DelayBreak_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBreakable._DelayBreak_d__10>.NativeClassPtr, 100667111);
			}

			// Token: 0x06005393 RID: 21395 RVA: 0x0012F14C File Offset: 0x0012D34C
			[CallerCount(0)]
			public unsafe _DelayBreak_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticBreakable._DelayBreak_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticBreakable._DelayBreak_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005394 RID: 21396 RVA: 0x0012F194 File Offset: 0x0012D394
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticBreakable._DelayBreak_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005395 RID: 21397 RVA: 0x0012F1C8 File Offset: 0x0012D3C8
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticBreakable._DelayBreak_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E7B RID: 7803
			// (get) Token: 0x06005396 RID: 21398 RVA: 0x0012F204 File Offset: 0x0012D404
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticBreakable._DelayBreak_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005397 RID: 21399 RVA: 0x0012F244 File Offset: 0x0012D444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84555, XrefRangeEnd = 84560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticBreakable._DelayBreak_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E7C RID: 7804
			// (get) Token: 0x06005398 RID: 21400 RVA: 0x0012F278 File Offset: 0x0012D478
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticBreakable._DelayBreak_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005399 RID: 21401 RVA: 0x000309F6 File Offset: 0x0002EBF6
			public _DelayBreak_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E78 RID: 7800
			// (get) Token: 0x0600539A RID: 21402 RVA: 0x0012F2B8 File Offset: 0x0012D4B8
			// (set) Token: 0x0600539B RID: 21403 RVA: 0x000309FF File Offset: 0x0002EBFF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticBreakable._DelayBreak_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticBreakable._DelayBreak_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E79 RID: 7801
			// (get) Token: 0x0600539C RID: 21404 RVA: 0x0012F2E0 File Offset: 0x0012D4E0
			// (set) Token: 0x0600539D RID: 21405 RVA: 0x00030A1A File Offset: 0x0002EC1A
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticBreakable._DelayBreak_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticBreakable._DelayBreak_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E7A RID: 7802
			// (get) Token: 0x0600539E RID: 21406 RVA: 0x0012F310 File Offset: 0x0012D510
			// (set) Token: 0x0600539F RID: 21407 RVA: 0x00030A39 File Offset: 0x0002EC39
			public unsafe StaticBreakable __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticBreakable._DelayBreak_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticBreakable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticBreakable._DelayBreak_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400372B RID: 14123
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400372C RID: 14124
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400372D RID: 14125
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400372E RID: 14126
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400372F RID: 14127
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003730 RID: 14128
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003731 RID: 14129
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003732 RID: 14130
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003733 RID: 14131
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
