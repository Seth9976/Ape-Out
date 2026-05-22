using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x0200028D RID: 653
	[ObfuscatedName("<PrivateImplementationDetails>")]
	public sealed class _PrivateImplementationDetails_ : Object
	{
		// Token: 0x06004977 RID: 18807 RVA: 0x00111670 File Offset: 0x0010F870
		// Note: this type is marked as 'beforefieldinit'.
		static _PrivateImplementationDetails_()
		{
			Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "<PrivateImplementationDetails>");
			_PrivateImplementationDetails_.NativeFieldInfoPtr__103CE80BE5A709BEE2A7690106C1E9AAAE9F46FB7205F4CC402727B6C072FC40 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "103CE80BE5A709BEE2A7690106C1E9AAAE9F46FB7205F4CC402727B6C072FC40");
			_PrivateImplementationDetails_.NativeFieldInfoPtr__4A08879A9977151E4797D24BB524732CB9BCB472CDAE95C8DA19BF6330C5B32E = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "4A08879A9977151E4797D24BB524732CB9BCB472CDAE95C8DA19BF6330C5B32E");
			_PrivateImplementationDetails_.NativeFieldInfoPtr__6B37F2DC3CBC36CB512AAB959CD9F9E3A5ED19A1282D3D8D0EF02E14C2935C71 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "6B37F2DC3CBC36CB512AAB959CD9F9E3A5ED19A1282D3D8D0EF02E14C2935C71");
			_PrivateImplementationDetails_.NativeFieldInfoPtr__73EE39B1E93D9396F505FCD459D92E96C22CB3984E5D7DC240A67EFEA1A78652 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "73EE39B1E93D9396F505FCD459D92E96C22CB3984E5D7DC240A67EFEA1A78652");
			_PrivateImplementationDetails_.NativeFieldInfoPtr__82AB60A547244F012E9567892CDCE9CC64EEC04C97C008BFB1788490F946E82E = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "82AB60A547244F012E9567892CDCE9CC64EEC04C97C008BFB1788490F946E82E");
			_PrivateImplementationDetails_.NativeFieldInfoPtr_A493ECF28E33055ADFE6BC8CA3E34E8C596165C57BE7A385BF0A924C74806A92 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "A493ECF28E33055ADFE6BC8CA3E34E8C596165C57BE7A385BF0A924C74806A92");
			_PrivateImplementationDetails_.NativeFieldInfoPtr_C8C84EFD411BCD77CC1602F0834CEE44BD12FEC75EEE3660B28E45B8BF8A0AC5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "C8C84EFD411BCD77CC1602F0834CEE44BD12FEC75EEE3660B28E45B8BF8A0AC5");
			_PrivateImplementationDetails_.NativeFieldInfoPtr_CA7077B165975BBBFF5E91BD20FB44CD21FA2E8812B555A99B457213E9D62417 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "CA7077B165975BBBFF5E91BD20FB44CD21FA2E8812B555A99B457213E9D62417");
			_PrivateImplementationDetails_.NativeFieldInfoPtr_EBFA40E1D395BE7D63761F4266493207C5B59876E9CFE6963F4AE02F924A44BF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "EBFA40E1D395BE7D63761F4266493207C5B59876E9CFE6963F4AE02F924A44BF");
			_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, 100670838);
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x00111760 File Offset: 0x0010F960
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 117829, RefRangeEnd = 117851, XrefRangeStart = 117828, XrefRangeEnd = 117829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ComputeStringHash(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x0002B401 File Offset: 0x00029601
		public _PrivateImplementationDetails_(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x0600497A RID: 18810 RVA: 0x001117A4 File Offset: 0x0010F9A4
		// (set) Token: 0x0600497B RID: 18811 RVA: 0x0002B40A File Offset: 0x0002960A
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealed2 _103CE80BE5A709BEE2A7690106C1E9AAAE9F46FB7205F4CC402727B6C072FC40
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealed2 valueTypeNPrivateSealed;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__103CE80BE5A709BEE2A7690106C1E9AAAE9F46FB7205F4CC402727B6C072FC40, (void*)(&valueTypeNPrivateSealed));
				return valueTypeNPrivateSealed;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__103CE80BE5A709BEE2A7690106C1E9AAAE9F46FB7205F4CC402727B6C072FC40, (void*)(&value));
			}
		}

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x0600497C RID: 18812 RVA: 0x001117C0 File Offset: 0x0010F9C0
		// (set) Token: 0x0600497D RID: 18813 RVA: 0x0002B418 File Offset: 0x00029618
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealed0 _4A08879A9977151E4797D24BB524732CB9BCB472CDAE95C8DA19BF6330C5B32E
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 valueTypeNPrivateSealed;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__4A08879A9977151E4797D24BB524732CB9BCB472CDAE95C8DA19BF6330C5B32E, (void*)(&valueTypeNPrivateSealed));
				return valueTypeNPrivateSealed;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__4A08879A9977151E4797D24BB524732CB9BCB472CDAE95C8DA19BF6330C5B32E, (void*)(&value));
			}
		}

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x0600497E RID: 18814 RVA: 0x001117DC File Offset: 0x0010F9DC
		// (set) Token: 0x0600497F RID: 18815 RVA: 0x0002B426 File Offset: 0x00029626
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealed2 _6B37F2DC3CBC36CB512AAB959CD9F9E3A5ED19A1282D3D8D0EF02E14C2935C71
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealed2 valueTypeNPrivateSealed;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__6B37F2DC3CBC36CB512AAB959CD9F9E3A5ED19A1282D3D8D0EF02E14C2935C71, (void*)(&valueTypeNPrivateSealed));
				return valueTypeNPrivateSealed;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__6B37F2DC3CBC36CB512AAB959CD9F9E3A5ED19A1282D3D8D0EF02E14C2935C71, (void*)(&value));
			}
		}

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x06004980 RID: 18816 RVA: 0x001117F8 File Offset: 0x0010F9F8
		// (set) Token: 0x06004981 RID: 18817 RVA: 0x0002B434 File Offset: 0x00029634
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealed4 _73EE39B1E93D9396F505FCD459D92E96C22CB3984E5D7DC240A67EFEA1A78652
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealed4 valueTypeNPrivateSealed;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__73EE39B1E93D9396F505FCD459D92E96C22CB3984E5D7DC240A67EFEA1A78652, (void*)(&valueTypeNPrivateSealed));
				return valueTypeNPrivateSealed;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__73EE39B1E93D9396F505FCD459D92E96C22CB3984E5D7DC240A67EFEA1A78652, (void*)(&value));
			}
		}

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x06004982 RID: 18818 RVA: 0x00111814 File Offset: 0x0010FA14
		// (set) Token: 0x06004983 RID: 18819 RVA: 0x0002B442 File Offset: 0x00029642
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealed1 _82AB60A547244F012E9567892CDCE9CC64EEC04C97C008BFB1788490F946E82E
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 valueTypeNPrivateSealed;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__82AB60A547244F012E9567892CDCE9CC64EEC04C97C008BFB1788490F946E82E, (void*)(&valueTypeNPrivateSealed));
				return valueTypeNPrivateSealed;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__82AB60A547244F012E9567892CDCE9CC64EEC04C97C008BFB1788490F946E82E, (void*)(&value));
			}
		}

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x06004984 RID: 18820 RVA: 0x00111830 File Offset: 0x0010FA30
		// (set) Token: 0x06004985 RID: 18821 RVA: 0x0002B450 File Offset: 0x00029650
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealed2 A493ECF28E33055ADFE6BC8CA3E34E8C596165C57BE7A385BF0A924C74806A92
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealed2 valueTypeNPrivateSealed;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_A493ECF28E33055ADFE6BC8CA3E34E8C596165C57BE7A385BF0A924C74806A92, (void*)(&valueTypeNPrivateSealed));
				return valueTypeNPrivateSealed;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_A493ECF28E33055ADFE6BC8CA3E34E8C596165C57BE7A385BF0A924C74806A92, (void*)(&value));
			}
		}

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x06004986 RID: 18822 RVA: 0x0011184C File Offset: 0x0010FA4C
		// (set) Token: 0x06004987 RID: 18823 RVA: 0x0002B45E File Offset: 0x0002965E
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealed3 C8C84EFD411BCD77CC1602F0834CEE44BD12FEC75EEE3660B28E45B8BF8A0AC5
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealed3 valueTypeNPrivateSealed;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_C8C84EFD411BCD77CC1602F0834CEE44BD12FEC75EEE3660B28E45B8BF8A0AC5, (void*)(&valueTypeNPrivateSealed));
				return valueTypeNPrivateSealed;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_C8C84EFD411BCD77CC1602F0834CEE44BD12FEC75EEE3660B28E45B8BF8A0AC5, (void*)(&value));
			}
		}

		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x06004988 RID: 18824 RVA: 0x00111868 File Offset: 0x0010FA68
		// (set) Token: 0x06004989 RID: 18825 RVA: 0x0002B46C File Offset: 0x0002966C
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealed5 CA7077B165975BBBFF5E91BD20FB44CD21FA2E8812B555A99B457213E9D62417
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealed5 valueTypeNPrivateSealed;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_CA7077B165975BBBFF5E91BD20FB44CD21FA2E8812B555A99B457213E9D62417, (void*)(&valueTypeNPrivateSealed));
				return valueTypeNPrivateSealed;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_CA7077B165975BBBFF5E91BD20FB44CD21FA2E8812B555A99B457213E9D62417, (void*)(&value));
			}
		}

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x0600498A RID: 18826 RVA: 0x00111884 File Offset: 0x0010FA84
		// (set) Token: 0x0600498B RID: 18827 RVA: 0x0002B47A File Offset: 0x0002967A
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealed4 EBFA40E1D395BE7D63761F4266493207C5B59876E9CFE6963F4AE02F924A44BF
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealed4 valueTypeNPrivateSealed;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_EBFA40E1D395BE7D63761F4266493207C5B59876E9CFE6963F4AE02F924A44BF, (void*)(&valueTypeNPrivateSealed));
				return valueTypeNPrivateSealed;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_EBFA40E1D395BE7D63761F4266493207C5B59876E9CFE6963F4AE02F924A44BF, (void*)(&value));
			}
		}

		// Token: 0x04002F96 RID: 12182
		private static readonly IntPtr NativeFieldInfoPtr__103CE80BE5A709BEE2A7690106C1E9AAAE9F46FB7205F4CC402727B6C072FC40;

		// Token: 0x04002F97 RID: 12183
		private static readonly IntPtr NativeFieldInfoPtr__4A08879A9977151E4797D24BB524732CB9BCB472CDAE95C8DA19BF6330C5B32E;

		// Token: 0x04002F98 RID: 12184
		private static readonly IntPtr NativeFieldInfoPtr__6B37F2DC3CBC36CB512AAB959CD9F9E3A5ED19A1282D3D8D0EF02E14C2935C71;

		// Token: 0x04002F99 RID: 12185
		private static readonly IntPtr NativeFieldInfoPtr__73EE39B1E93D9396F505FCD459D92E96C22CB3984E5D7DC240A67EFEA1A78652;

		// Token: 0x04002F9A RID: 12186
		private static readonly IntPtr NativeFieldInfoPtr__82AB60A547244F012E9567892CDCE9CC64EEC04C97C008BFB1788490F946E82E;

		// Token: 0x04002F9B RID: 12187
		private static readonly IntPtr NativeFieldInfoPtr_A493ECF28E33055ADFE6BC8CA3E34E8C596165C57BE7A385BF0A924C74806A92;

		// Token: 0x04002F9C RID: 12188
		private static readonly IntPtr NativeFieldInfoPtr_C8C84EFD411BCD77CC1602F0834CEE44BD12FEC75EEE3660B28E45B8BF8A0AC5;

		// Token: 0x04002F9D RID: 12189
		private static readonly IntPtr NativeFieldInfoPtr_CA7077B165975BBBFF5E91BD20FB44CD21FA2E8812B555A99B457213E9D62417;

		// Token: 0x04002F9E RID: 12190
		private static readonly IntPtr NativeFieldInfoPtr_EBFA40E1D395BE7D63761F4266493207C5B59876E9CFE6963F4AE02F924A44BF;

		// Token: 0x04002F9F RID: 12191
		private static readonly IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;

		// Token: 0x020003F5 RID: 1013
		[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=12")]
		[StructLayout(2)]
		public struct ValueTypeNPrivateSealed0
		{
			// Token: 0x06005B76 RID: 23414 RVA: 0x000342A2 File Offset: 0x000324A2
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeNPrivateSealed0()
			{
				Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=12");
			}

			// Token: 0x06005B77 RID: 23415 RVA: 0x000342B8 File Offset: 0x000324B8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020003F6 RID: 1014
		[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=20")]
		[StructLayout(2)]
		public struct ValueTypeNPrivateSealed1
		{
			// Token: 0x06005B78 RID: 23416 RVA: 0x000342CA File Offset: 0x000324CA
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeNPrivateSealed1()
			{
				Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=20");
			}

			// Token: 0x06005B79 RID: 23417 RVA: 0x000342E0 File Offset: 0x000324E0
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020003F7 RID: 1015
		[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=24")]
		[StructLayout(2)]
		public struct ValueTypeNPrivateSealed2
		{
			// Token: 0x06005B7A RID: 23418 RVA: 0x000342F2 File Offset: 0x000324F2
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeNPrivateSealed2()
			{
				Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=24");
			}

			// Token: 0x06005B7B RID: 23419 RVA: 0x00034308 File Offset: 0x00032508
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed2>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020003F8 RID: 1016
		[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=28")]
		[StructLayout(2)]
		public struct ValueTypeNPrivateSealed3
		{
			// Token: 0x06005B7C RID: 23420 RVA: 0x0003431A File Offset: 0x0003251A
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeNPrivateSealed3()
			{
				Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=28");
			}

			// Token: 0x06005B7D RID: 23421 RVA: 0x00034330 File Offset: 0x00032530
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed3>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020003F9 RID: 1017
		[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=32")]
		[StructLayout(2)]
		public struct ValueTypeNPrivateSealed4
		{
			// Token: 0x06005B7E RID: 23422 RVA: 0x00034342 File Offset: 0x00032542
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeNPrivateSealed4()
			{
				Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=32");
			}

			// Token: 0x06005B7F RID: 23423 RVA: 0x00034358 File Offset: 0x00032558
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed4>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020003FA RID: 1018
		[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=48")]
		[StructLayout(2)]
		public struct ValueTypeNPrivateSealed5
		{
			// Token: 0x06005B80 RID: 23424 RVA: 0x0003436A File Offset: 0x0003256A
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeNPrivateSealed5()
			{
				Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=48");
			}

			// Token: 0x06005B81 RID: 23425 RVA: 0x00034380 File Offset: 0x00032580
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed5>.NativeClassPtr, ref this));
			}
		}
	}
}
