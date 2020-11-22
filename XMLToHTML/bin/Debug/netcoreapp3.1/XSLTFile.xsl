<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0"
   xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <body>
        <h2>Tanks</h2>
        <table border="1">
          <tr bgcolor="#9acd32">
            <th>Name</th> 
            <th>Country</th>
            <th>YearOfIssue</th>
            <th>MainCaliber</th>
            <th>Armor</th>
            <th>Weight</th> 
          </tr>
          <xsl:for-each select="Tanks/Tank">
            <tr>
              <td>
                <xsl:value-of select="@Name"/>
              </td>
              <td>
                <xsl:value-of select="@Country"/>
              </td>
              <td>
                <xsl:value-of select="@YearOfIssue"/>
              </td>
              <td>
                <xsl:value-of select="@MainCaliber"/>
              </td>
              <td>
                <xsl:value-of select="@Armor"/>
              </td>
              <td>
                <xsl:value-of select="@Weight"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>

</xsl:stylesheet>
