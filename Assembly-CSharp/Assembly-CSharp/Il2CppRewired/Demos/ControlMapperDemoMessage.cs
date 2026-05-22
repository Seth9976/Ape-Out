using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.UI.ControlMapper;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppRewired.Demos
{
	// Token: 0x0200021C RID: 540
	public class ControlMapperDemoMessage : MonoBehaviour
	{
		// Token: 0x060041AE RID: 16814 RVA: 0x000F4934 File Offset: 0x000F2B34
		// Note: this type is marked as 'beforefieldinit'.
		static ControlMapperDemoMessage()
		{
			Il2CppClassPointerStore<ControlMapperDemoMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "ControlMapperDemoMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlMapperDemoMessage>.NativeClassPtr);
			ControlMapperDemoMessage.NativeFieldInfoPtr_controlMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapperDemoMessage>.NativeClassPtr, "controlMapper");
			ControlMapperDemoMessage.NativeFieldInfoPtr_defaultSelectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapperDemoMessage>.NativeClassPtr, "defaultSelectable");
			ControlMapperDemoMessage.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapperDemoMessage>.NativeClassPtr, 100669717);
			ControlMapperDemoMessage.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapperDemoMessage>.NativeClassPtr, 100669718);
			ControlMapperDemoMessage.NativeMethodInfoPtr_OnControlMapperClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapperDemoMessage>.NativeClassPtr, 100669719);
			ControlMapperDemoMessage.NativeMethodInfoPtr_OnControlMapperOpened_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapperDemoMessage>.NativeClassPtr, 100669720);
			ControlMapperDemoMessage.NativeMethodInfoPtr_SelectDefault_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapperDemoMessage>.NativeClassPtr, 100669721);
			ControlMapperDemoMessage.NativeMethodInfoPtr_SelectDefaultDeferred_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapperDemoMessage>.NativeClassPtr, 100669722);
			ControlMapperDemoMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapperDemoMessage>.NativeClassPtr, 100669723);
		}

		// Token: 0x060041AF RID: 16815 RVA: 0x000F4A18 File Offset: 0x000F2C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105632, XrefRangeEnd = 105659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlMapperDemoMessage.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041B0 RID: 16816 RVA: 0x000F4A4C File Offset: 0x000F2C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105659, XrefRangeEnd = 105660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlMapperDemoMessage.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041B1 RID: 16817 RVA: 0x000F4A80 File Offset: 0x000F2C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105660, XrefRangeEnd = 105673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnControlMapperClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlMapperDemoMessage.NativeMethodInfoPtr_OnControlMapperClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041B2 RID: 16818 RVA: 0x000F4AB4 File Offset: 0x000F2CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnControlMapperOpened()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlMapperDemoMessage.NativeMethodInfoPtr_OnControlMapperOpened_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041B3 RID: 16819 RVA: 0x000F4AE8 File Offset: 0x000F2CE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105707, RefRangeEnd = 105708, XrefRangeStart = 105673, XrefRangeEnd = 105707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlMapperDemoMessage.NativeMethodInfoPtr_SelectDefault_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041B4 RID: 16820 RVA: 0x000F4B1C File Offset: 0x000F2D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105708, XrefRangeEnd = 105711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SelectDefaultDeferred()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlMapperDemoMessage.NativeMethodInfoPtr_SelectDefaultDeferred_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060041B5 RID: 16821 RVA: 0x000F4B5C File Offset: 0x000F2D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlMapperDemoMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlMapperDemoMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlMapperDemoMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041B6 RID: 16822 RVA: 0x000280F3 File Offset: 0x000262F3
		public ControlMapperDemoMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x060041B7 RID: 16823 RVA: 0x000F4B98 File Offset: 0x000F2D98
		// (set) Token: 0x060041B8 RID: 16824 RVA: 0x000280FC File Offset: 0x000262FC
		public unsafe ControlMapper controlMapper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlMapperDemoMessage.NativeFieldInfoPtr_controlMapper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControlMapper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlMapperDemoMessage.NativeFieldInfoPtr_controlMapper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x060041B9 RID: 16825 RVA: 0x000F4BC8 File Offset: 0x000F2DC8
		// (set) Token: 0x060041BA RID: 16826 RVA: 0x0002811B File Offset: 0x0002631B
		public unsafe Selectable defaultSelectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlMapperDemoMessage.NativeFieldInfoPtr_defaultSelectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlMapperDemoMessage.NativeFieldInfoPtr_defaultSelectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400285C RID: 10332
		private static readonly IntPtr NativeFieldInfoPtr_controlMapper;

		// Token: 0x0400285D RID: 10333
		private static readonly IntPtr NativeFieldInfoPtr_defaultSelectable;

		// Token: 0x0400285E RID: 10334
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400285F RID: 10335
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04002860 RID: 10336
		private static readonly IntPtr NativeMethodInfoPtr_OnControlMapperClosed_Private_Void_0;

		// Token: 0x04002861 RID: 10337
		private static readonly IntPtr NativeMethodInfoPtr_OnControlMapperOpened_Private_Void_0;

		// Token: 0x04002862 RID: 10338
		private static readonly IntPtr NativeMethodInfoPtr_SelectDefault_Private_Void_0;

		// Token: 0x04002863 RID: 10339
		private static readonly IntPtr NativeMethodInfoPtr_SelectDefaultDeferred_Private_IEnumerator_0;

		// Token: 0x04002864 RID: 10340
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003B2 RID: 946
		[ObfuscatedName("Rewired.Demos.ControlMapperDemoMessage+<SelectDefaultDeferred>d__7")]
		public sealed class _SelectDefaultDeferred_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x0600596A RID: 22890 RVA: 0x0014391C File Offset: 0x00141B1C
			// Note: this type is marked as 'beforefieldinit'.
			static _SelectDefaultDeferred_d__7()
			{
				Il2CppClassPointerStore<ControlMapperDemoMessage._SelectDefaultDeferred_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapperDemoMessage>.NativeClassPtr, "<SelectDefaultDeferred>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlMapperDemoMessage._SelectDefaultDeferred_d__7>.NativeClassPtr);
				ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapperDemoMessage._SelectDefaultDeferred_d__7>.NativeClassPtr, "<>1__state");
				ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapperDemoMessage._SelectDefaultDeferred_d__7>.NativeClassPtr, "<>2__current");
				ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapperDemoMessage._SelectDefaultDeferred_d__7>.NativeClassPtr, "<>4__this");
				ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapperDemoMessage._SelectDefaultDeferred_d__7>.NativeClassPtr, 100669724);
				ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapperDemoMessage._SelectDefaultDeferred_d__7>.NativeClassPtr, 100669725);
				ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapperDemoMessage._SelectDefaultDeferred_d__7>.NativeClassPtr, 100669726);
				ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapperDemoMessage._SelectDefaultDeferred_d__7>.NativeClassPtr, 100669727);
				ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapperDemoMessage._SelectDefaultDeferred_d__7>.NativeClassPtr, 100669728);
				ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapperDemoMessage._SelectDefaultDeferred_d__7>.NativeClassPtr, 100669729);
			}

			// Token: 0x0600596B RID: 22891 RVA: 0x001439FC File Offset: 0x00141BFC
			[CallerCount(0)]
			public unsafe _SelectDefaultDeferred_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlMapperDemoMessage._SelectDefaultDeferred_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600596C RID: 22892 RVA: 0x00143A44 File Offset: 0x00141C44
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600596D RID: 22893 RVA: 0x00143A78 File Offset: 0x00141C78
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170020B1 RID: 8369
			// (get) Token: 0x0600596E RID: 22894 RVA: 0x00143AB4 File Offset: 0x00141CB4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600596F RID: 22895 RVA: 0x00143AF4 File Offset: 0x00141CF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105627, XrefRangeEnd = 105632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170020B2 RID: 8370
			// (get) Token: 0x06005970 RID: 22896 RVA: 0x00143B28 File Offset: 0x00141D28
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005971 RID: 22897 RVA: 0x0003339A File Offset: 0x0003159A
			public _SelectDefaultDeferred_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020AE RID: 8366
			// (get) Token: 0x06005972 RID: 22898 RVA: 0x00143B68 File Offset: 0x00141D68
			// (set) Token: 0x06005973 RID: 22899 RVA: 0x000333A3 File Offset: 0x000315A3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170020AF RID: 8367
			// (get) Token: 0x06005974 RID: 22900 RVA: 0x00143B90 File Offset: 0x00141D90
			// (set) Token: 0x06005975 RID: 22901 RVA: 0x000333BE File Offset: 0x000315BE
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020B0 RID: 8368
			// (get) Token: 0x06005976 RID: 22902 RVA: 0x00143BC0 File Offset: 0x00141DC0
			// (set) Token: 0x06005977 RID: 22903 RVA: 0x000333DD File Offset: 0x000315DD
			public unsafe ControlMapperDemoMessage __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControlMapperDemoMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlMapperDemoMessage._SelectDefaultDeferred_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B60 RID: 15200
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003B61 RID: 15201
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003B62 RID: 15202
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003B63 RID: 15203
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003B64 RID: 15204
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B65 RID: 15205
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003B66 RID: 15206
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003B67 RID: 15207
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B68 RID: 15208
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
